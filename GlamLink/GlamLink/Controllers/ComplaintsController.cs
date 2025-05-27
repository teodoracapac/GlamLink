using Microsoft.AspNetCore.Mvc;
using GlamLink.Models;
using Microsoft.EntityFrameworkCore;
using GlamLink.Data;

namespace GlamLink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private static readonly Dictionary<string, int> DomainToAdminId = new Dictionary<string, int>
        {
            { "Functionality", 1 },
            { "VisualIssue", 2 },
            { "Performance", 3 },
            { "Other", 4 }
        };

        public ComplaintsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("submit")]
        public async Task<IActionResult> SubmitComplaint([FromBody] ComplaintDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!DomainToAdminId.TryGetValue(dto.Domain, out int adminId))
                return BadRequest("Invalid domain.");

            // Check if admin exists first
            var admin = await _context.Admins.FindAsync(adminId);
            if (admin == null)
                return NotFound("Admin not found for this domain.");

            var complaint = new Complaints
            {
                idUser = dto.idUser,
                Subject = dto.Subject,
                Text = dto.Text,
                idAdmin = admin.idAdmin,
                Status = "Pending"
            };

            _context.Complaints.Add(complaint);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Complaint submitted successfully!" });
        }

        [HttpGet("admin/{adminId}")]
        public async Task<IActionResult> GetComplaintsForAdmin(int adminId)
        {
            var adminExists = await _context.Admins.AnyAsync(a => a.idAdmin == adminId);
            if (!adminExists)
                return NotFound("Admin not found.");

            var complaints = await _context.Complaints
                .Where(c => c.idAdmin == adminId)
                .Select(c => new
                {
                    c.idComplaint,
                    c.Subject,
                    c.Text,
                    c.idUser,
                    Username = _context.Users
                        .Where(u => u.idUser == c.idUser)
                        .Select(u => u.Username)
                        .FirstOrDefault(),
                    c.Status
                })

                .ToListAsync();

            return Ok(complaints);
        }

        [HttpPut("mark-solved/{idComplaint}")]
        public async Task<IActionResult> MarkComplaintAsSolved(int idComplaint)
        {
            var complaint = await _context.Complaints.FindAsync(idComplaint);

            if (complaint == null)
                return NotFound("Complaint not found.");

            complaint.Status = "Solved";
            await _context.SaveChangesAsync();

            return Ok(new { message = "Complaint marked as solved." });
        }


        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetComplaintsForUser(int userId)
        {
            var userExists = await _context.Users.AnyAsync(u => u.idUser == userId);
            if (!userExists)
                return NotFound("User not found.");

            var complaints = await _context.Complaints
                .Where(c => c.idUser == userId)
                .Select(c => new
                {
                    c.idComplaint,
                    c.Subject,
                    c.Text,
                    c.Status
                })
                .ToListAsync();

            return Ok(complaints);
        }

    }

}
