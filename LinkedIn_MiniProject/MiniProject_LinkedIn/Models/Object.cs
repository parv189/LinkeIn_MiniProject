using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject_LinkedIn.Models
{
    public class Object
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
        public virtual ObjectType ? ObjectType { get; set; }

        public virtual Location ? Location { get; set; }
        public virtual Location ? Location1 { get; set; }
        public virtual Location ? Location2 { get; set; }
    }
}
