using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniProject_LinkedIn.Models
{
    public class PostLikes
    {
        [Key]
        public int PostLike_Id { get; set; }
        //[ForeignKey("UserInformation")]
        public int? User_Id { get; set; }
        [ForeignKey("User_Post")]
        public int? Post_Id { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; }
        [JsonIgnore]
        public virtual User_Information? UserInformation { get; set; }
        [JsonIgnore]
        public virtual User_Information? UserInformation1 { get; set; }
        [JsonIgnore]
        public virtual User_Information? UserInformation2 { get; set; }
        [JsonIgnore]
        public virtual User_Post? User_Post { get; set; }

    }
}
