using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Code.SqlServer
{

    public class UserPostRepository : GenericRepository<User_Post>, IUserPost
    {
        public UserPostRepository(UserContext context) : base(context)
        {
        }
    }
}
