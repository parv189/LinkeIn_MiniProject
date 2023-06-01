using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject_LinkedIn.Models
{
    public class CommentLikes
    {
        [Key]
        public int CommentLike_Id { get; set; }
        [ForeignKey("PostComments")]
        public int ? PostComment_Id { get; set; }
        //[ForeignKey("UserInformation")]
        public int? User_ID { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; }
        public virtual PostComments? PostComments { get; set; }

        public virtual User_Information? UserInformation { get; set; }
        public virtual User_Information? UserInformation1 { get; set; }
        public virtual User_Information? UserInformation2 { get; set; }

    }
}
