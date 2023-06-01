using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject_LinkedIn.Models
{
    public class Location
    {
        [Key]
        public int Location_Id { get; set; }
       
        public int? City_Id { get; set; } 
     
        public int? State_Id { get; set; } 
     
        public int? country_Id { get; set; }
        //[ForeignKey("Object")]
       
        public int ?CreatedById { get; set; }
        public DateTime ?CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; }
        public virtual Object? Object { get; set; }
        public virtual Object? Object1 { get; set; }
        public virtual Object? Object2 { get; set; }
        public virtual Company? Company { get; set; }

    }
}
