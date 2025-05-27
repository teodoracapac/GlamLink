using GlamLink.Data;
using GlamLink.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GlamLink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EventsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("AddEvent")]
        public async Task<IActionResult> AddEvent([FromBody] EventsDTO newEvent)
        {
            // Check if an event exists at the same date and time
            var exists = await _context.Events
                .AnyAsync(ev => ev.idUser == newEvent.idUser && ev.Date == newEvent.Date);

            if (exists)
            {
                return BadRequest("An event already exists at this date and time.");
            }

            var eventEntity = new Events
            {
                Name = newEvent.Name,
                Date = newEvent.Date,
                idUser = newEvent.idUser,
                idOutfit = newEvent.idOutfit,
            };

            _context.Events.Add(eventEntity);

            await _context.SaveChangesAsync();

            return Ok();
        }

            [HttpDelete("DeleteEvent")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var eventToDelete = await _context.Events.FindAsync(id);
            if (eventToDelete == null)
            {
                return NotFound(new { message = $"Event with ID {id} not found." });
            }

            try
            {
                _context.Events.Remove(eventToDelete);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Event deleted successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

         [HttpGet("User/{idUser}")]
         public async Task<IActionResult> GetEventsForUser(int idUser)
         {
             var events = await (from ev in _context.Events
                                 join o in _context.Outfits on ev.idOutfit equals o.idOutfit
                                 where ev.idUser == idUser
                                 select new
                                 {
                                     ev.idEvent,
                                     ev.Name,
                                     ev.Date,
                                     ev.idOutfit,
                                     ev.idUser,
                                     OutfitName = o.Name 
                                 }).ToListAsync();
             return Ok(events);
         }
       


        [HttpPut("UpdateEvent/{id}")]
        public async Task<IActionResult> UpdateEvent(int id, [FromBody] EventsDTO eventDto)
        {
            if (eventDto == null)
                return BadRequest("Event data is null.");

            var existingEvent = await _context.Events.FindAsync(id);
            if (existingEvent == null)
                return NotFound(new { message = $"Event with ID {id} not found." });

            existingEvent.Name = eventDto.Name;
            existingEvent.Date = eventDto.Date;
            existingEvent.idOutfit = eventDto.idOutfit;
            existingEvent.idUser = eventDto.idUser;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(new { message = "Event updated successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
