using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2.Datas;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/media")]
    public class MediaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MediaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> UploadMedia(Models.Media media)
        {
            _context.media.Add(media);
            await _context.SaveChangesAsync();
            return Ok(media);
        }

        [HttpGet("{mediaId}")]
        public async Task<IActionResult> GetMedia(int mediaId)
        {
            var media = await _context.media.FindAsync(mediaId);

            if (media == null)
                return NotFound();

            return Ok(media);
        }

        [HttpGet("trip/{tripId}")]
        public async Task<IActionResult> GetMediaByTrip(int tripId)
        {
            var mediaList = await _context.media
                .Where(m => m.TripId == tripId)
                .OrderByDescending(m => m.UploadedAt)
                .ToListAsync();

            return Ok(mediaList);
        }

        [HttpDelete("{mediaId}")]
        public async Task<IActionResult> DeleteMedia(int mediaId)
        {
            var media = await _context.media.FindAsync(mediaId);

            if (media == null)
                return NotFound();

            _context.media.Remove(media);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}