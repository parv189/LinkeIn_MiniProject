using System.ComponentModel.DataAnnotations;

namespace MiniProject_LinkedIn.Models
{
    public class CheckPostLike
    {
        [Key]
        public int Post_Id { get; set; }
        public int? UserConnection_Id { get; set; }
        public int? User_ID { get; set; }
        public int? ConnectedUser_ID { get; set; }
        public string? Status { get; set; }
    }
}
