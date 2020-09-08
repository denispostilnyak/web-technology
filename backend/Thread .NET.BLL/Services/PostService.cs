using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.BLL.Hubs;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;
using MailKit.Net.Smtp;
using MailKit.Security;
using System;
using System.Net.Mail;
using System.Net;

namespace Thread_.NET.BLL.Services
{
    public sealed class PostService : BaseService
    {
        private readonly IHubContext<PostHub> _postHub;

        public PostService(ThreadContext context, IMapper mapper, IHubContext<PostHub> postHub) : base(context, mapper) {
            _postHub = postHub;
        }

        public async Task<ICollection<PostDTO>> GetAllPosts() {
            var posts = await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Reactions)
                    .ThenInclude(reaction => reaction.User)
                        .ThenInclude(user => user.Avatar)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Reactions)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Author)
                .OrderByDescending(post => post.CreatedAt)
                .ToListAsync();

            return _mapper.Map<ICollection<PostDTO>>(posts);
        }

        public async Task<ICollection<PostDTO>> GetAllPosts(int userId) {
            var posts = await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Author)
                .Where(p => p.AuthorId == userId) // Filter here
                .ToListAsync();

            return _mapper.Map<ICollection<PostDTO>>(posts);
        }

        public async Task<PostDTO> CreatePost(PostCreateDTO postDto) {
            var postEntity = _mapper.Map<Post>(postDto);

            _context.Posts.Add(postEntity);
            await _context.SaveChangesAsync();

            var createdPost = await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .FirstAsync(post => post.Id == postEntity.Id);

            var createdPostDTO = _mapper.Map<PostDTO>(createdPost);
            await _postHub.Clients.All.SendAsync("NewPost", createdPostDTO);

            return createdPostDTO;
        }

        public async Task<PostDTO> EditPost(EditPostDTO postDto) {

            var editPost = _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Where(post => post.Id == postDto.Id)
                .FirstOrDefault();
            editPost.Body = postDto.Body;
            if (editPost.Preview == null) {
                editPost.Preview = new Image();
                editPost.Preview.URL = postDto.PreviewImage;
            } else {
                editPost.Preview.URL = postDto.PreviewImage;
            }
            await _context.SaveChangesAsync();

            var editedPostDTO = _mapper.Map<PostDTO>(editPost);
            await _postHub.Clients.All.SendAsync("Edit", editedPostDTO);

            return editedPostDTO;
        }

        public async Task DeletePost(int id) {
            var currentPost = _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Where(p => p.Id == id)
                .FirstOrDefault();
            if (currentPost == null) {
                throw new NotFoundException(nameof(Post), id);
            }

            currentPost.IsDeleted = true;

            await _context.SaveChangesAsync();

            var deletedPostDTO = _mapper.Map<PostDTO>(currentPost);
            await _postHub.Clients.All.SendAsync("Delete", deletedPostDTO);

        }

        public async Task SharePost(SharePostDTO share) {
            var link = "http://localhost:4200/post/{0}";
            link = string.Format(link, share.PostId);

            var user = await _context.Users.Where(u => u.Id == share.UserId).FirstOrDefaultAsync();

            var body = string.Format("{0} wants to share post with you. Follow the link {1}", user.UserName, link);

            var emailService = new EmailService();
            emailService.SendEmail(body, user.Email, share.Email, "Check post!");
        }

        public async Task NotifyAboutLike(SharePostDTO notify) {
            var link = "http://localhost:4200/post/{0}";
            link = string.Format(link, notify.PostId);

            var userFrom = await _context.Users.Where(u => u.Id == notify.UserId).FirstOrDefaultAsync();
            var userTo = await _context.Posts.Where(u => u.Id == notify.PostId).Select(p => p.Author).FirstOrDefaultAsync();

            var body = string.Format("{0} liked your post. Follow the link {1}", userFrom.UserName, link);

            var emailService = new EmailService();
            emailService.SendEmail(body, userFrom.Email, userTo.Email, "Check post!");
        }
    }
}
