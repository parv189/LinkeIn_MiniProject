using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniProject_LinkedIn.Models
{
    public class UserConnections
    {
        [Key]
        public int UserConnection_Id { get; set; }
        //[ForeignKey("UserInformation1")]
        public int ?User_ID { get; set; }
        //[ForeignKey("UserInformation2")]
        public int? ConnectedUser_ID { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedByDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedByDate { get; set; }
        [JsonIgnore]
        public virtual User_Information? UserInformation1 { get; set; }
        [JsonIgnore]
        public virtual User_Information? UserInformation2 { get; set; }
        [JsonIgnore]
        public virtual User_Information? UserInformation3 { get; set; }
        [JsonIgnore]
        public virtual User_Information? UserInformation4 { get; set; }
    }
}
