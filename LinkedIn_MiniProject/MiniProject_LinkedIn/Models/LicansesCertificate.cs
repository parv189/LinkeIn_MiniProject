using System.ComponentModel.DataAnnotations;

namespace MiniProject_LinkedIn.Models
{
    public class LicansesCertificate

    {
        [Key]
        public int LC_Id { get; set; }
        public string ? LC_Title { get; set; }
        public int ?User_ID { get; set; }

        public string? LC_Link { get; set; }

        public string? LC_Details { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; } 
        public virtual User_Information? UserInformation1 { get; set; }
        public virtual User_Information? UserInformation2 { get; set; }
        public virtual User_Information? UserInformation3 { get; set; }
    }
}
