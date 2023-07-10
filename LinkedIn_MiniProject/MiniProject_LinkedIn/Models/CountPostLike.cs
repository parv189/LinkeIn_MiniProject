using System.ComponentModel.DataAnnotations;

namespace MiniProject_LinkedIn.Models
{
    public class CountPostLike
    {
        [Key]
        public int Post_Id { get; set; }
        public int? LikeCounts { get; set; }
    }
}
