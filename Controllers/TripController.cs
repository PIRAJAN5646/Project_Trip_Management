using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2.Datas;
using Project2.Models;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/trips")]
    public class TripController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TripController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrip(Trips trip)
        {
            _context.trips.Add(trip);
            await _context.SaveChangesAsync();
            return Ok(trip);
        }

        [HttpGet("{tripId}")]
        public async Task<IActionResult> GetTrip(int tripId)
        {
            var trip = await _context.trips.FindAsync(tripId);

            if (trip == null)
                return NotFound();

            return Ok(trip);
        }

        [HttpPut("{tripId}")]
        public async Task<IActionResult> UpdateTrip(int tripId, Trips trip)
        {
            if (tripId != trip.TripId)
                return BadRequest();

            _context.Entry(trip).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(trip);
        }

        [HttpDelete("{tripId}")]
        public async Task<IActionResult> DeleteTrip(int tripId)
        {
            var trip = await _context.trips.FindAsync(tripId);

            if (trip == null)
                return NotFound();

            _context.trips.Remove(trip);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}