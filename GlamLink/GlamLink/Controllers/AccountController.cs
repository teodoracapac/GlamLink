using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using GlamLink.Data;
using GlamLink.Models;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AccountController(ApplicationDbContext context)
    {
        _context = context;
    }

    // POST: api/account/verify
    [HttpPost("verify")]
    public IActionResult Verify([FromBody] VerifyAccountDTO dto)
    {
        // First try to find a matching user
        var user = _context.Users
            .FirstOrDefault(u => u.Username == dto.Username && u.Password == dto.Password);

        if (user != null)
        {
            return Ok(new
            {
                AccountType = "User",
                Id = user.idUser,
                Username = user.Username
            });
        }

        // If not found as user, try admin
        var admin = _context.Admins
            .FirstOrDefault(a => a.Username == dto.Username && a.Password == dto.Password);

        if (admin != null)
        {
            return Ok(new
            {
                AccountType = "Admin",
                Id = admin.idAdmin,
                Username = admin.Username
            });
        }

        // Neither matched
        return Unauthorized("Invalid credentials");
    }


    [HttpPut("update")]
    public IActionResult Update([FromBody] UpdateAccountDTO dto)
    {
        if (string.IsNullOrWhiteSpace(dto.NewUsername) || string.IsNullOrWhiteSpace(dto.NewPassword))
            return BadRequest("Username and password cannot be empty.");

        // Check if new username already exists in Users or Admins (excluding current account)
        bool usernameExistsInUsers = _context.Users.Any(u => u.Username == dto.NewUsername && u.idUser != dto.Id);
        bool usernameExistsInAdmins = _context.Admins.Any(a => a.Username == dto.NewUsername && a.idAdmin != dto.Id);

        if (usernameExistsInUsers || usernameExistsInAdmins)
        {
            return Conflict("This username is already taken.");
        }

        if (dto.AccountType == "User")
        {
            var user = _context.Users.FirstOrDefault(u => u.idUser == dto.Id);
            if (user == null)
                return NotFound("User not found");

            user.Username = dto.NewUsername;
            user.Password = dto.NewPassword;
            _context.SaveChanges();

            return Ok("User account updated successfully");
        }
        else if (dto.AccountType == "Admin")
        {
            var admin = _context.Admins.FirstOrDefault(a => a.idAdmin == dto.Id);
            if (admin == null)
                return NotFound("Admin not found");

            admin.Username = dto.NewUsername;
            admin.Password = dto.NewPassword;
            _context.SaveChanges();

            return Ok("Admin account updated successfully");
        }

        return BadRequest("Invalid account type");
    }



    [HttpDelete("delete/{idUser}")]
    public async Task<IActionResult> DeleteUser(int idUser)
    {
        var user = await _context.Users.FindAsync(idUser);
        if (user == null)
            return NotFound("User not found.");

        var clothes = _context.Clothes.Where(c => c.idUser == idUser);
        _context.Clothes.RemoveRange(clothes);

       
        var complaints = _context.Complaints.Where(c => c.idUser == idUser);
        _context.Complaints.RemoveRange(complaints);

     
        var events = _context.Events.Where(e => e.idUser == idUser);
        _context.Events.RemoveRange(events);

      
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return Ok(new { message = "User deleted successfully." });
    }


    [HttpGet("allUsers")]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _context.Users
            .Select(u => new
            {
                u.idUser,
                u.Username
            })
            .ToListAsync();

        return Ok(users);
    }

}
