using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Code.SqlServer
{
    public class PostlikesRepository : GenericRepository<PostLikes>, IPostLikes
    {
        public PostlikesRepository(UserContext context) : base(context)
        {
        }
    }
}
