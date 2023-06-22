using System.ComponentModel.DataAnnotations;

namespace MiniProject_LinkedIn.Models
{
    public class Invitations
    {
        [Key]
        public int UserConnection_Id { get; set; }
        public int? User_ID { get; set; }
        public int? ConnectedUser_ID { get; set; }
        public DateTime? CreatedByDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? User_Profile_photo { get; set; }
        public string? User_Headline { get; set; }
        public string? status { get; set; }
    }
}
