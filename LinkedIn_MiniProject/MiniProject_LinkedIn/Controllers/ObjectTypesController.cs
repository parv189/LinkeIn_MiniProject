using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectTypesController : ControllerBase
    {
        private readonly IObjectType objectType;
        public ObjectTypesController(IObjectType objectType)
        {
            this.objectType = objectType;
        }
        [EnableCors("Policy1")]
        [HttpPost]
        public ActionResult<ObjectType> AddObjectType(ObjectType request)
        {
            ObjectType objt = new ObjectType();
            objt.ObjectType_Name = request.ObjectType_Name;
            objt.CreatedById = request.CreatedById;
            var newobjt = objectType.Add(objt);
            return newobjt;
        }
        [EnableCors("Policy1")]
        [HttpGet]
        public ActionResult<IEnumerator<ObjectType>> GetObjectType()
        {
            return objectType.Index().ToList();
        }
    }
}
