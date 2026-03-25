using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Models
{
    public class Media
    {
        [Key]
        public int MediaId { get; set; }
        [ForeignKey("Trips")]
        public int TripId { get; set; }
        [Required]
        public string FileUrl { get; set; }
        [Required]
        public string FileType {  get; set; }
        [Required]
        public DateTime UploadedAt { get; set; } = DateTime.Now;
    }
}
