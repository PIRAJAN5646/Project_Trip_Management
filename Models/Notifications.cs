using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Models
{
    public class Notifications
    {
        [Key]
        public int NotificationId { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public bool IsRead { get; set; } = false;
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
