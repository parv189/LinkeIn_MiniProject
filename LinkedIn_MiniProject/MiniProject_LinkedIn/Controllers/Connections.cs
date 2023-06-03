using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public ActionResult<IEnumerable<UserConnections>> GetConnections()
        {
            return connection.Index().ToList();
        }
        [HttpPost]
        public ActionResult<UserConnections> newConnection(UserConnections request)
        {
            UserConnections us = new UserConnections();
            us.User_ID = request.User_ID;
            us.ConnectedUser_ID = request.ConnectedUser_ID;
            var conn = connection.Add(us);
            us.CreatedById = us.User_ID;
            connection.Update(us);
            return conn;
        }


    }
}
