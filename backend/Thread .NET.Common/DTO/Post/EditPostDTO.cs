using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Thread_.NET.Common.DTO.Post
{
    public sealed class EditPostDTO
    {
        public int Id { get; set; }
        public string PreviewImage { get; set; }
        public string Body { get; set; }
    }
}
