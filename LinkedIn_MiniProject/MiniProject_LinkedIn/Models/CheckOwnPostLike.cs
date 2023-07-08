using System.ComponentModel.DataAnnotations;

namespace MiniProject_LinkedIn.Models
{
    public class CheckOwnPostLike
    {
        [Key]
        public int Post_Id { get; set; }
        public int? Postby { get; set; }
        public int? Mylikes { get; set; }
        public string? Status { get; set; }
    }
}
