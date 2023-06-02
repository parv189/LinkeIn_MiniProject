using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniProject_LinkedIn.Models
{
    public class User_Information
    {

        [Key]
        public int User_ID { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = String.Empty;
        [Required]
        public string Email { get; set; } = String.Empty;
        [Required]
        public string PhoneNumber { get; set; } = String.Empty;
        [Required]
        public byte[]? PasswordHash { get; set; }
        [Required]
        public byte[]? PasswordSalt { get; set; }

        public string? User_Profile_photo { get; set; }

        public string? User_Background_photo { get; set; }
        public string? User_Headline { get; set; }
        public string? User_Current_position { get; set; } 
        public string? User_Education { get; set; }
        public string? User_Location { get; set; }
        public string? User_Industry { get; set; }
        public string? User_Contact_Info { get; set; }
        public string? User_Summary { get; set; }
        public int ?CreatedById { get; set; }
        public DateTime CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime ModifiedByDate { get; set; }
        [JsonIgnore]
        public virtual ICollection<Experience> ? experiences { get; set; }
        [JsonIgnore]
        public virtual ICollection<Experience> ? experiences1 { get; set; }
        [JsonIgnore]
        public virtual ICollection<Experience> ? experiences2 { get; set; }
        [JsonIgnore]
        public virtual ICollection<Skill>? skills { get; set; }
        [JsonIgnore]
        public virtual ICollection<Skill>? skills1 { get; set; }
        [JsonIgnore]
        public virtual ICollection<Skill>? skills2 { get; set; }
        [JsonIgnore]
        public virtual ICollection<Project>? Project { get; set; }
        [JsonIgnore]
        public virtual ICollection<Project>? Project1 { get; set; }
        [JsonIgnore]
        public virtual ICollection<Project>? Project2 { get; set; }
        [JsonIgnore]
        public virtual ICollection<PostComments>? PostComments { get; set; }
        [JsonIgnore]
        public virtual ICollection<PostComments>? PostComments1 { get; set; }
        [JsonIgnore]
        public virtual ICollection<PostComments>? PostComments2 { get; set; }
        [JsonIgnore]

        public virtual ICollection<CommentLikes>?commentLikes { get; set; }
        [JsonIgnore]
        public virtual ICollection<CommentLikes>?commentLikes1 { get; set; }
        [JsonIgnore]
        public virtual ICollection<CommentLikes>?commentLikes2 { get; set; }
        [JsonIgnore]

        public virtual ICollection<UserConnections>? UserConnections1 {get; set; }
        [JsonIgnore]
        public virtual ICollection<UserConnections>? UserConnections2 {get; set; }
        [JsonIgnore]
        public virtual ICollection<UserConnections>? UserConnections3 {get; set; }
        [JsonIgnore]
        public virtual ICollection<UserConnections>? UserConnections4 {get; set; }
        [JsonIgnore]

        public virtual ICollection<LicansesCertificate>? LicansesCertificate1 { get; set; }
        [JsonIgnore]
        public virtual ICollection<LicansesCertificate>? LicansesCertificate2 { get; set; }
        [JsonIgnore]
        public virtual ICollection<LicansesCertificate>? LicansesCertificate3 { get; set; }
        [JsonIgnore]
        public virtual ICollection<User_Post> ? user_Posts { get; set; }
        [JsonIgnore]
        public virtual ICollection<User_Post> ? user_Posts1 { get; set; }
        [JsonIgnore]
        public virtual ICollection<User_Post> ? user_Posts2 { get; set; }
        [JsonIgnore]

        public virtual ICollection<PostLikes>? postLikes { get; set; }
        [JsonIgnore]
        public virtual ICollection<PostLikes>? postLikes1 { get; set; }
        [JsonIgnore]
        public virtual ICollection<PostLikes>? postLikes2 { get; set; }
        [JsonIgnore]

        public virtual User_Information? UserInformation1 { get; set; }
        [JsonIgnore]
        public virtual User_Information? UserInformation2 { get; set; }



    }
   
}
