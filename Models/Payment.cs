using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [ForeignKey("Bookings")]
        public int BookingId { get; set; }
        [Required]
        public string PaymentGateway { get; set; }
        [Required]
        public string TransactionId { get; set; }
        [ForeignKey("Bookings")]
        public double Amount { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime PaidAt { get; set; }= DateTime.Now;
    }
}
