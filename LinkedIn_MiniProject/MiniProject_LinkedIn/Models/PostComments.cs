using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject_LinkedIn.Models
{
    public class PostComments
    {
        [Key]
        public int PostComment_Id { get; set; }
        [ForeignKey("User_Post")]
        public int? Post_Id { get; set; }
        //[ForeignKey("UserInformation")]
        public int? User_Id { get; set; }
        [Required]
        public string? Comment_Content { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedByDate { get; set; } = DateTime.Now;
        public int ?ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; }
        public virtual User_Information ? UserInformation { get; set; }
        public virtual User_Information ? UserInformation1 { get; set; }
        public virtual User_Information ? UserInformation2 { get; set; }
        public virtual User_Post ?User_Post { get; set; }
        public virtual ICollection<CommentLikes>? CommentLikes { get; set; }
    }
}
