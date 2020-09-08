using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.Comment;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.Extensions;

namespace Thread_.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly CommentService _commentService;
        private readonly LikeService _likeService;

        public CommentsController(CommentService commentService, LikeService likeService)
        {
            _commentService = commentService;
            _likeService = likeService;
        }

        [HttpPost]
        public async Task<ActionResult<CommentDTO>> CreatePost([FromBody] NewCommentDTO comment)
        {
            comment.AuthorId = this.GetUserIdFromToken();
            return Ok(await _commentService.CreateComment(comment));
        }

        [HttpPost("reaction")]
        public async Task<IActionResult> LikeDislikeComment(NewReactionDTO reaction) {
            reaction.UserId = this.GetUserIdFromToken();

            await _likeService.LikeDislikeComment(reaction);
            return Ok();
        }

        [HttpPut("edit")]
        public async Task<IActionResult> EditComment(CommentDTO comment) {
            return Ok(await _commentService.EditComment(comment));
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteComment(int id) {
            await _commentService.DeleteComment(id);

            return NoContent();
        }
    }
}