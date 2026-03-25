using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Models
{
    public class Bookings
    {
        [Key]
        public int BookingId { get; set; }
        [ForeignKey("Trips")]
        public int TripId { get; set; }
        [Required]
        public string BookingType { get; set; }
        [Required]
        public string Vendor { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime BookingDate { get; set; } = DateTime.Now;
    }
}
