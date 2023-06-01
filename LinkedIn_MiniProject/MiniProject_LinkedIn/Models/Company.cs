using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject_LinkedIn.Models
{
    public class Company
    {
        [Key]
        public int Company_Id { get; set; }
        public string? Company_Name { get; set; } = string.Empty;
        [ForeignKey("Location")]
        public int ? Location_Id { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; }
        public Location ? Location { get; set; }
        public virtual Experience ? Experience { get; set; }
    }
}
