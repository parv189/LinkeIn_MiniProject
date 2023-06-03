using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Code.SqlServer
{
    public class UserConnectionRepository : GenericRepository<UserConnections>,IConnectionRepo
    {
        public UserConnectionRepository(UserContext userContext):base(userContext)
        {

        }
    }
}
