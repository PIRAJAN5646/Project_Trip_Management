using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Models
{
    public class TripMembers
    {
        [Key]
        public int TripMemberId { get; set; }
        [ForeignKey("Trips")]
        public int TripId { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
