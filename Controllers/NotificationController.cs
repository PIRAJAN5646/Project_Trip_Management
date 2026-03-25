using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/notifications")]
    public class NotificationController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendNotification(int userId, string message)
        {
            return Ok(new
            {
                User = userId,
                Message = message,
                Status = "Notification Sent"
            });
        }

        [HttpGet("{userId}")]
        public IActionResult GetNotifications(int userId)
        {
            return Ok($"Notifications for user {userId}");
        }
    }
}
