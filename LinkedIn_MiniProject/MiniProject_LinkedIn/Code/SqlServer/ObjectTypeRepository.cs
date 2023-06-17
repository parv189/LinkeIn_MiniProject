using Microsoft.AspNetCore.Cors;
using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Code.SqlServer
{
    public class ObjectTypeRepository : GenericRepository<ObjectType>, IObjectType
    {
        public ObjectTypeRepository(UserContext context) : base(context)
        {
        }
       
    }
}
