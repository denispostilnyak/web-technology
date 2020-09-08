using System;
using System.Collections.Generic;
using Thread_.NET.Common.DTO.Comment;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.Common.DTO.User;

namespace Thread_.NET.Common.DTO.Post
{
    public sealed class SharePostDTO
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
    }
}
