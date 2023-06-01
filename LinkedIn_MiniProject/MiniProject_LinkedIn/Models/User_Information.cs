using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public virtual ICollection<Experience> ? experiences { get; set; }
        public virtual ICollection<Experience> ? experiences1 { get; set; }
        public virtual ICollection<Experience> ? experiences2 { get; set; }
        public virtual ICollection<Skill>? skills { get; set; }
        public virtual ICollection<Skill>? skills1 { get; set; }
        public virtual ICollection<Skill>? skills2 { get; set; }
        public virtual ICollection<Project>? Project { get; set; }
        public virtual ICollection<Project>? Project1 { get; set; }
        public virtual ICollection<Project>? Project2 { get; set; }
        public virtual ICollection<PostComments>? PostComments { get; set; }
        public virtual ICollection<PostComments>? PostComments1 { get; set; }
        public virtual ICollection<PostComments>? PostComments2 { get; set; }

        public virtual ICollection<CommentLikes>?commentLikes { get; set; } 
        public virtual ICollection<CommentLikes>?commentLikes1 { get; set; } 
        public virtual ICollection<CommentLikes>?commentLikes2 { get; set; } 

        public virtual ICollection<UserConnections>? UserConnections1 {get; set; }
        public virtual ICollection<UserConnections>? UserConnections2 {get; set; }
        public virtual ICollection<UserConnections>? UserConnections3 {get; set; }
        public virtual ICollection<UserConnections>? UserConnections4 {get; set; }

        public virtual ICollection<LicansesCertificate>? LicansesCertificate1 { get; set; }
        public virtual ICollection<LicansesCertificate>? LicansesCertificate2 { get; set; }
        public virtual ICollection<LicansesCertificate>? LicansesCertificate3 { get; set; }
        public virtual ICollection<User_Post> ? user_Posts { get; set; }
        public virtual ICollection<User_Post> ? user_Posts1 { get; set; }
        public virtual ICollection<User_Post> ? user_Posts2 { get; set; }

        public virtual ICollection<PostLikes>? postLikes { get; set; }
        public virtual ICollection<PostLikes>? postLikes1 { get; set; }
        public virtual ICollection<PostLikes>? postLikes2 { get; set; }

        public virtual User_Information? UserInformation1 { get; set; }
        public virtual User_Information? UserInformation2 { get; set; }



    }
   
}
