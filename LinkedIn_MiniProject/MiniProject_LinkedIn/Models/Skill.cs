using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject_LinkedIn.Models
{
    public class Skill
    {
        [Key]
        public int Skill_Id { get; set; }
        public string ?Skill_Name { get; set; } = string.Empty;
        [ForeignKey("UserInformation")]
        public int? User_Id { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; }

        public virtual User_Information ? UserInformation { get; set; }
        public virtual User_Information?  UserInformation1 { get; set; }
        public virtual User_Information ? UserInformation2 { get; set; }
    }
}
