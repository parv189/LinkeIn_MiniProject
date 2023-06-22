using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Connections : ControllerBase
    {
        private readonly IConnectionRepo connection;
        public Connections(IConnectionRepo connection)
        {
            this.connection = connection;
        }
        [EnableCors("Policy1")]
        [HttpGet]
        public ActionResult<IEnumerable<UserConnections>> GetConnections()
        {
            return connection.Index().ToList();
        }
        [EnableCors("Policy1")]
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<UserConnections>> GetConnectionsById(int id)
        {
            List<UserConnections> conn = connection.Find(x => x.User_ID == id).ToList();
            if (conn == null)
            {
                return NotFound();
            }
            return conn;
        }
        [EnableCors("Policy1")]
        [HttpPost("{uid},{ouid}")]
        public ActionResult<UserConnections> newConnection(int uid,int ouid)
        {
            UserConnections uc = new UserConnections();
            uc.User_ID = uid;
            uc.ConnectedUser_ID = ouid;
            uc.status = "pending";
            var conn = connection.Add(uc);
            uc.CreatedById = uc.User_ID;
            connection.Update(uc);
            return conn;
        }
        [EnableCors("Policy1")]
        [HttpPut("UpdateConnections/{id}")]
        public ActionResult<UserConnections> UpdateUserbyId(int id, UserConnections request)
        {
            if (id != request.UserConnection_Id)
            {
                return BadRequest();
            }
            try
            {
                var updateconn = connection.Update(request);
                return updateconn;

            }
            catch (DbUpdateConcurrencyException)
            {
                if (connection.IsExist(x => x.UserConnection_Id == request.UserConnection_Id))
                {
                    throw;
                }
                else
                {
                    return NotFound();
                }
            }

        }

    }
}
