using MiniProject_LinkedIn.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniProject_LinkedIn.Code.Interfaces;

namespace MiniProject_LinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectsController : ControllerBase
    {

        private readonly IObjects objects;
        public ObjectsController(IObjects objects)
        {
            this.objects = objects;
        }
        [EnableCors("Policy1")]
        [HttpPost]
        public ActionResult<Objects> addObject(Objects request)
        {
            Objects ob = new Objects();
            ob.Object_Name = request.Object_Name;
            ob.ObjectType_Id = request.ObjectType_Id;
            ob.CreatedById = request.CreatedById;
            var obj = objects.Add(ob);
            return obj;

        }
        [EnableCors("Policy1")]
        [HttpGet]
        public ActionResult<IEnumerable<Objects>> getObject()
        {
            return objects.Index().ToList();
        }
    }
}
