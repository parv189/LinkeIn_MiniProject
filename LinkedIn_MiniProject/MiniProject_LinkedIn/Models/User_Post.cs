using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniProject_LinkedIn.Models
{
    public class User_Post
    {
        [Key]
        public int Post_Id { get; set; }
        //[ForeignKey("UserInformation")]
        public int? User_Id { get; set; }
        public string Photo_Url { get; set; } = string.Empty;
        public string? content { get; set; } 
        public int? CreatedById { get; set; }
        public DateTime? CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; }
        [JsonIgnore]
        public virtual User_Information ? UserInformation { get; set; }
        [JsonIgnore]
        public virtual ICollection<PostLikes>? PostLikes { get; set; }
        [JsonIgnore]
        public virtual ICollection<PostComments>? PostComments { get; set; }
        [JsonIgnore]
        public virtual User_Information? UserInformation1 { get; set; }
        [JsonIgnore]
        public virtual User_Information? UserInformation2 { get; set; }
    }
}
