using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Models
{
    public class Trips
    {
        [Key]
        public int TripId {  get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        public DateTime StartDate {  get; set; }= DateTime.Now;
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
