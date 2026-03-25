using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Models
{
    public class Expenses
    {
        [Key]
        public int ExpenseId { get; set; }
        [ForeignKey("Trips")]
        public int TripId { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime ExpenseDate { get; set; }=DateTime.Now;
    }
}
