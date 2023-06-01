using System.ComponentModel.DataAnnotations;

namespace MiniProject_LinkedIn.Models
{
    public class ObjectType
    {
        [Key]
        public int ObjectType_Id { get; set; }
        [Required]
        public string? ObjectType_Name { get; set; } = string.Empty;
        public int? CreatedById { get; set; }
        public DateTime? CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; }

        public virtual ParentObject ? ParentObject { get; set; }
        public virtual ICollection<Object> ? Objects { get; set; }

    }
}
