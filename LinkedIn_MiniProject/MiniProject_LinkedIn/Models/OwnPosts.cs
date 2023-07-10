using System.ComponentModel.DataAnnotations;

namespace MiniProject_LinkedIn.Models
{
    public class OwnPosts
    {
        [Key]
        public int Post_Id { get; set; }
        public int? User_ID { get; set; }
        public string? Photo_Url { get; set; }
        public string? content { get; set; }
        public DateTime? CreatedByDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? User_Profile_photo { get; set; }
        public int? LikeCounts { get; set; }
        public string? Status { get; set; }
    }
}
