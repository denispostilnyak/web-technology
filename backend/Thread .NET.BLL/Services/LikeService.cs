using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Hubs;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.Common.DTO.User;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public sealed class LikeService : BaseService
    {
        private readonly IHubContext<PostHub> _postHub;

        public LikeService(ThreadContext context, IMapper mapper, IHubContext<PostHub> postHub) : base(context, mapper) {
            _postHub = postHub;
        }

        public async Task LikePost(NewReactionDTO reaction)
        {
            var reactionsDTO = new ReactionDTO();
            reactionsDTO.IsLike = reaction.IsLike;

            var user = _context.Users.Where(user => user.Id == reaction.UserId).FirstOrDefault();
            
            reactionsDTO.User = _mapper.Map<UserDTO>(user);

            var likes = _context.PostReactions.Where(x => x.UserId == reaction.UserId && x.PostId == reaction.EntityId);

            if (likes.Any() && likes.Select(l => l.IsLike).FirstOrDefault() == reaction.IsLike)
            {
                _context.PostReactions.RemoveRange(likes);
                await _context.SaveChangesAsync();

                var firstPost = GetPost(reaction).Result;
                var firstPostDTO = _mapper.Map<PostDTO>(firstPost);

                await _postHub.Clients.All.SendAsync("Like", firstPostDTO);
                return;
            }
            if (!likes.Any()) {
                _context.PostReactions.Add(new DAL.Entities.PostReaction {
                    PostId = reaction.EntityId,
                    IsLike = reaction.IsLike,
                    UserId = reaction.UserId
                });

                await _context.SaveChangesAsync();

                var secondPost = GetPost(reaction).Result;
                var secondPostDTO = _mapper.Map<PostDTO>(secondPost);

                await _postHub.Clients.All.SendAsync("Like", secondPostDTO);
                return;
            }

            _context.PostReactions.RemoveRange(likes);
           await  _context.SaveChangesAsync();

            _context.PostReactions.Add(new DAL.Entities.PostReaction {
                PostId = reaction.EntityId,
                IsLike = reaction.IsLike,
                UserId = reaction.UserId
            });

            await _context.SaveChangesAsync();

            var post = GetPost(reaction).Result;
            var postDTO = _mapper.Map<PostDTO>(post);

            await _postHub.Clients.All.SendAsync("Like", postDTO);

        }

        public async Task LikeDislikeComment(NewReactionDTO reaction) {
            var likes = _context.CommentReactions.Where(x => x.UserId == reaction.UserId && x.CommentId == reaction.EntityId);

            if (likes.Any() && likes.Select(l => l.IsLike).FirstOrDefault() == reaction.IsLike) {
                _context.CommentReactions.RemoveRange(likes);
                await _context.SaveChangesAsync();

                return;
            }
            if (!likes.Any()) {
                _context.CommentReactions.Add(new DAL.Entities.CommentReaction {
                    CommentId = reaction.EntityId,
                    IsLike = reaction.IsLike,
                    UserId = reaction.UserId
                });

                await _context.SaveChangesAsync();
                return;
            }

            _context.CommentReactions.RemoveRange(likes);
            await _context.SaveChangesAsync();

            _context.CommentReactions.Add(new DAL.Entities.CommentReaction {
                CommentId = reaction.EntityId,
                IsLike = reaction.IsLike,
                UserId = reaction.UserId
            });

            await _context.SaveChangesAsync();
        }

        public async Task<Post> GetPost( NewReactionDTO reaction) {
            return await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Reactions)
                    .ThenInclude(reaction => reaction.User)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Reactions)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Author)
                .Where(post => post.Id == reaction.EntityId)
                .FirstOrDefaultAsync();
        }
    }
}
