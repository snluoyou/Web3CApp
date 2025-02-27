using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace Web3CApp.Controllers
{
    public class VideoController : Controller
    {
        private const string VideoStoragePath = "wwwroot/videos/";
        
        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), VideoStoragePath, fileName);
                
                using var stream = new FileStream(filePath, FileMode.Create);
                await file.CopyToAsync(stream);
                
                return Json(new { url = $"/videos/{fileName}" });
            }
            return BadRequest();
        }
        
        [HttpGet("{name}")]
        public IActionResult GetVideo(string name)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), VideoStoragePath, name);
            if (System.IO.File.Exists(filePath))
            {
                return File(System.IO.File.ReadAllBytes(filePath), "video/mp4");
            }
            return NotFound();
        }
    }
}