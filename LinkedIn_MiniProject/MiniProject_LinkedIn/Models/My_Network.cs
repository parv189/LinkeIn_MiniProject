using System.ComponentModel.DataAnnotations;

namespace MiniProject_LinkedIn.Models
{
    public class My_Network
    {
        [Key]
        public int? UserConnection_Id { get; set; }
        public int? me { get; set; }
        public int? connection { get; set; }
        public DateTime? CreatedByDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? User_Profile_photo { get; set; }
    }
}
