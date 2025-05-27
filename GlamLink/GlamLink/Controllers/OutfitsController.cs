using GlamLink.Data;
using GlamLink.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class OutfitsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    
    public OutfitsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddOutfit([FromBody] Outfits outfit)
    {
        if (outfit == null || string.IsNullOrWhiteSpace(outfit.Name))
            return BadRequest("Invalid outfit data.");

        if (outfit.idUser <= 0)
            return BadRequest("UserId is required.");

        if (outfit.Creation_Date == default)
            outfit.Creation_Date = DateTime.Now;

        _context.Outfits.Add(outfit);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Outfit added successfully", outfitId = outfit.idOutfit });
    }

    [HttpGet("user/{userId}")]
    public IActionResult GetOutfitsByUser(int userId)
    {
        var userOutfits = _context.Outfits
                                  .Where(o => o.idUser == userId)
                                  .ToList();

        return Ok(userOutfits);
    }

    [HttpPost("upload")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UploadOutfit([FromForm] UploadOutfitRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
            return BadRequest("Name is required.");

        if (request.File == null || request.File.Length == 0)
            return BadRequest("A valid image file is required.");

        string uploadsFolder = Path.Combine("wwwroot", "Outfits");
        if (!Directory.Exists(uploadsFolder))
            Directory.CreateDirectory(uploadsFolder);

        string fileName = $"{Path.GetFileNameWithoutExtension(request.File.FileName)}.jpg";
        string filePath = Path.Combine(uploadsFolder, fileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await request.File.CopyToAsync(stream);
        }

        var newOutfit = new Outfits
        {
            Name = request.Name,
            Creation_Date = request.Creation_Date ?? DateTime.Now
        };

        _context.Outfits.Add(newOutfit);
        await _context.SaveChangesAsync();

        if (request.SelectedClothingIds != null && request.SelectedClothingIds.Any())
        {
            foreach (var clothesId in request.SelectedClothingIds)
            {
                var link = new OutfitClothes
                {
                    idOutfit = newOutfit.idOutfit,
                    idClothes = clothesId
                };
                _context.OutfitClothes.Add(link);
            }
            await _context.SaveChangesAsync();
        }

        return Ok(new { message = "Outfit uploaded successfully", outfitId = newOutfit.idOutfit });
    }


    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteOutfit(int id)
    {
        var outfit = await _context.Outfits.FindAsync(id);
        if (outfit == null)
            return NotFound(new { message = "Outfit not found." });

        // Check if the outfit is linked to any event(s)
        var linkedEvents = _context.Events.Where(e => e.idOutfit == id).ToList();
        if (linkedEvents.Any())
        {
            _context.Events.RemoveRange(linkedEvents);
        }

        // Delete the outfit itself
        _context.Outfits.Remove(outfit);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Outfit and any associated events deleted successfully." });
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> UpdateOutfit(int id, [FromBody] Outfits updatedOutfit)
    {
        var outfit = await _context.Outfits.FindAsync(id);
        if (outfit == null) return NotFound();

        outfit.Name = updatedOutfit.Name;
        outfit.DressImage = updatedOutfit.DressImage;
        outfit.TopImage = updatedOutfit.TopImage;
        outfit.BottomImage = updatedOutfit.BottomImage;
        outfit.JacketImage = updatedOutfit.JacketImage;
        outfit.ShoesImage = updatedOutfit.ShoesImage;
        outfit.AccessoriesImage = updatedOutfit.AccessoriesImage;

        await _context.SaveChangesAsync();
        return Ok(new { message = "Outfit updated successfully" });
    }

    [HttpGet("{id}")]
    public IActionResult GetOutfitById(int id)
    {
        var outfit = _context.Outfits.FirstOrDefault(o => o.idOutfit == id);
        if (outfit == null) return NotFound();
        return Ok(outfit);
    }

    [HttpGet("check-links/{id}")]
    public async Task<IActionResult> CheckLinks(int id)
    {
        bool isLinkedToEvent = await _context.Events.AnyAsync(e => e.idOutfit == id);

        var result = new
        {
            IsLinkedToEvent = isLinkedToEvent,
            IsLinkedToOutfit = true 
        };

        return Ok(result);
    }

}
