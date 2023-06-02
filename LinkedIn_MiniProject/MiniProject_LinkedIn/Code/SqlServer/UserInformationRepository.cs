using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Code.SqlServer
{
    public class UserInformationRepository :GenericRepository<User_Information>,IUserInfoRepository
    {
        public UserInformationRepository(UserContext userContext) : base(userContext) { }
    }
}
