using Microsoft.AspNetCore.Mvc;
using GlamLink.Data;
using GlamLink.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace GlamLink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ClosetController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
 
        public ClosetController(ApplicationDbContext context)
        {
            _context = context;

        }

        [HttpPost("upload")]
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UploadItem([FromForm] UploadItemRequest request)
        {
            if (string.IsNullOrEmpty(request.Category))
                return BadRequest("Category is required.");

            if (request.File == null || request.File.Length == 0)
                return BadRequest("A valid image file is required.");

            // Prepare save path
            string uploadsFolder = Path.Combine("wwwroot", "ClosetItems", request.Category);
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            // Standardize and uniquify file name
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string fileName = $"{timestamp}_{Path.GetFileNameWithoutExtension(request.File.FileName)}.jpg";
            string filePath = Path.Combine(uploadsFolder, fileName);

            // Save image
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await request.File.CopyToAsync(stream);
            }

            // Save item to DB, including file name
            var newItem = new Clothes
            {
                Name = request.Name,
                Category = request.Category,
                Color = request.Color,
                Season = request.Season,
                idUser = request.idUser,
                imageFileName = fileName 
            };

            _context.Clothes.Add(newItem);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Item uploaded successfully." });
        }


        // Method to get all items in a specific category

        [HttpGet("items")]
        public async Task<IActionResult> GetCategoryItems([FromQuery] string category, [FromQuery] int userId)
        {
            if (string.IsNullOrEmpty(category))
                return BadRequest("Category is required.");

            var items = await _context.Clothes
                .Where(c => c.Category == category && c.idUser == userId)
                .ToListAsync();

            var baseUrl = $"{Request.Scheme}://{Request.Host}";

            var result = items.Select(item => new
            {
                item.Name,
                item.Color,
                item.Season,
                item.Category,
                ImageUrl = $"{baseUrl}/ClosetItems/{item.Category}/{item.imageFileName}"
            });

            return Ok(result);
        }

       
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteItem([FromQuery] string name, [FromQuery] int userId)
        {
            if (string.IsNullOrWhiteSpace(name) || userId <= 0)
                return BadRequest("Item name and userId are required.");

            // 1. Find the clothing item from DB
            var item = await _context.Clothes
                .FirstOrDefaultAsync(c => c.Name == name && c.idUser == userId);

            if (item == null)
                return NotFound("Clothing item not found.");

            // 2. Build the full image URL used in outfits
            string baseUrl = $"{Request.Scheme}://{Request.Host}"; // e.g., https://localhost:44337
            string fullImageUrl = $"{baseUrl}/ClosetItems/{item.Category}/{item.imageFileName}";

            // 3. Find all outfits that contain the clothing item's image
            var outfitsToDelete = await _context.Outfits
                .Where(o =>
                    o.DressImage == fullImageUrl ||
                    o.TopImage == fullImageUrl ||
                    o.BottomImage == fullImageUrl ||
                    o.JacketImage == fullImageUrl ||
                    o.ShoesImage == fullImageUrl ||
                    o.AccessoriesImage == fullImageUrl)
                .ToListAsync();

            // 4. If no outfits matched, just delete the clothing item
            if (!outfitsToDelete.Any())
            {
                var imagePath = Path.Combine("wwwroot", "ClosetItems", item.Category, item.imageFileName);
                if (System.IO.File.Exists(imagePath))
                    System.IO.File.Delete(imagePath);

                _context.Clothes.Remove(item);
                await _context.SaveChangesAsync();

                return Ok(new
                {
                    message = "Clothing item deleted. No outfits matched the image.",
                    expectedImageUrl = fullImageUrl
                });
            }

            // 5. Get IDs of outfits to delete
            var deletedOutfitIds = outfitsToDelete.Select(o => o.idOutfit).ToList();

            // 6. Find and delete events that use these outfits
            var eventsToDelete = await _context.Events
                .Where(e => deletedOutfitIds.Contains(e.idOutfit))
                .ToListAsync();

            _context.Events.RemoveRange(eventsToDelete);

            // 7. Delete the image from disk
            var imageDiskPath = Path.Combine("wwwroot", "ClosetItems", item.Category, item.imageFileName);
            if (System.IO.File.Exists(imageDiskPath))
                System.IO.File.Delete(imageDiskPath);

            // 8. Remove outfits and the clothing item
            _context.Outfits.RemoveRange(outfitsToDelete);
            _context.Clothes.Remove(item);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Clothing item, related outfits, and related events deleted successfully.",
                deletedOutfits = outfitsToDelete.Count,
                deletedEvents = eventsToDelete.Count
            });
        }


        [HttpGet("check-links")]
        public async Task<IActionResult> CheckIfItemIsLinked([FromQuery] string name, [FromQuery] int userId)
        {
            if (string.IsNullOrWhiteSpace(name) || userId <= 0)
                return BadRequest("Invalid parameters.");

            var item = await _context.Clothes.FirstOrDefaultAsync(c => c.Name == name && c.idUser == userId);
            if (item == null)
                return NotFound("Item not found.");

            string baseUrl = $"{Request.Scheme}://{Request.Host}";
            string fullImageUrl = $"{baseUrl}/ClosetItems/{item.Category}/{item.imageFileName}";

            var outfitIds = await _context.Outfits
                .Where(o =>
                    o.DressImage == fullImageUrl ||
                    o.TopImage == fullImageUrl ||
                    o.BottomImage == fullImageUrl ||
                    o.JacketImage == fullImageUrl ||
                    o.ShoesImage == fullImageUrl ||
                    o.AccessoriesImage == fullImageUrl)
                .Select(o => o.idOutfit)
                .ToListAsync();

            bool isLinkedToOutfit = outfitIds.Any();
            bool isLinkedToEvent = await _context.Events.AnyAsync(ev => outfitIds.Contains(ev.idOutfit));

            return Ok(new
            {
                IsLinkedToOutfit = isLinkedToOutfit,
                IsLinkedToEvent = isLinkedToEvent
            });
        }
    }
}


