using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniProject_LinkedIn.Models
{
    public class Objects
    {
        [Key]
        public int Object_Id { get; set; }
        [Required]
        public string Object_Name { get; set; } = string.Empty;
        [ForeignKey("ObjectType")]
        public int? ObjectType_Id { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; }
        [JsonIgnore]
        public virtual ObjectType ? ObjectType { get; set; }
    }
}
