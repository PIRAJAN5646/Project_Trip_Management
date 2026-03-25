using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2.Datas;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/locations")]
    public class LocationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LocationController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddLocation(Models.Locations location)
        {
            _context.locations.Add(location);
            await _context.SaveChangesAsync();
            return Ok(location);
        }

        [HttpGet("trip/{tripId}")]
        public async Task<IActionResult> GetLocations(int tripId)
        {
            var locations = await _context.locations
                .Where(l => l.TripId == tripId).ToListAsync();

            return Ok(locations);
        }
    }
}
