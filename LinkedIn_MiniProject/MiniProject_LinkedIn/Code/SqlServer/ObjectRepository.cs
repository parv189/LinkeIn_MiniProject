using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Models;
namespace MiniProject_LinkedIn.Code.SqlServer
{
    public class ObjectRepository : GenericRepository<Objects>, IObjects
    {
        public ObjectRepository(UserContext context) : base(context)
        {
        }
    }
}
