using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Comment;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public sealed class CommentService : BaseService
    {
        public CommentService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<CommentDTO> CreateComment(NewCommentDTO newComment)
        {
            var commentEntity = _mapper.Map<Comment>(newComment);

            _context.Comments.Add(commentEntity);
            await _context.SaveChangesAsync();

            var createdComment = await _context.Comments
                .Include(comment => comment.Author)
                    .ThenInclude(user => user.Avatar)
                .FirstAsync(comment => comment.Id == commentEntity.Id);

            return _mapper.Map<CommentDTO>(createdComment);
        }

        public async Task<CommentDTO> EditComment(CommentDTO comment) {

            var currentComment = await _context.Comments.Where(c => c.Id == comment.Id).FirstOrDefaultAsync();
            if (currentComment == null) {
                throw new NotFoundException(nameof(Comment), comment.Id);
            }
            currentComment.Body = comment.Body;
            currentComment.UpdatedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return _mapper.Map<CommentDTO>(currentComment);
        }

        public async Task DeleteComment(int id) {
            var currentComment =  await _context.Comments.Where(c => c.Id == id).FirstOrDefaultAsync();

            if (currentComment == null) {
                throw new NotFoundException(nameof(Comment));
            }

            currentComment.IsDeleted = true;
            await _context.SaveChangesAsync();

        }
    }
}
