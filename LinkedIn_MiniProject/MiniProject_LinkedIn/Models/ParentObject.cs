using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject_LinkedIn.Models
{
    public class ParentObject
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ObjectType")]
        public int ? Parent_Id { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; }
        public virtual ObjectType ? ObjectType { get; set; }

    }
}
