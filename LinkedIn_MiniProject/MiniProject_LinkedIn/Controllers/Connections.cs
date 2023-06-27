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
        [HttpPost("addconnection/{id}")]
        public ActionResult<UserConnections> newConnection(int id,User_Information req)
        {
            UserConnections uc = new UserConnections();
            uc.User_ID = id;
            uc.ConnectedUser_ID = req.User_ID;
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
        [EnableCors("Policy1")]
        [HttpDelete("{id}")]
        public ActionResult<UserConnections> DeleteConnection(int id)
        {
            try
            {
                if (!ConnectionExists(id))
                {
                    return NotFound();
                }
                var c = connection.Find(x => x.UserConnection_Id == id).FirstOrDefault();
                var deleteconnection = connection.Delete(c);
                return deleteconnection;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private bool ConnectionExists(int id)
        {
            return connection.IsExist(x => x.UserConnection_Id == id);
        }
    }
}
