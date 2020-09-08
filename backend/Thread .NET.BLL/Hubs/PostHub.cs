using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.Common.DTO.Post;

namespace Thread_.NET.BLL.Hubs
{
    public sealed class PostHub : Hub
    {
        public async Task Send(PostDTO post)
        {
            await Clients.All.SendAsync("NewPost", post);
        }

        public async Task Like(PostDTO post) {
            await Clients.All.SendAsync("Like", post);
        }

        public async Task Edit(PostDTO post) {
            await Clients.All.SendAsync("Edit", post);
        }

        public async Task Delete(PostDTO post) {
            await Clients.All.SendAsync("Delete", post);
        }
    }
}
