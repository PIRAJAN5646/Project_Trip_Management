using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}