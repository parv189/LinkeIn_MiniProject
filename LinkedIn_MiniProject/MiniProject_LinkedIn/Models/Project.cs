using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject_LinkedIn.Models
{
    public class Project
    {
        [Key]
        public int Project_Id { get; set; }
        [ForeignKey("UserInformation")]
        public int? User_Id { get; set; }
        public string? Project_Name { get; set; } = string.Empty;
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; }

        public User_Information? UserInformation { get; set; }
        public User_Information? UserInformation1 { get; set; }
        public User_Information? UserInformation2 { get; set; }
    }
    
}
