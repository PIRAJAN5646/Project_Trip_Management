using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Models
{
    public class Locations
    {
        [Key]
        public int LocationId { get; set; }
        [ForeignKey("Trips")]
        public int TripId { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public string PlaceName { get; set; }
        [Required]
        public DateTime Timestamp {  get; set; }= DateTime.Now;
    }
}
