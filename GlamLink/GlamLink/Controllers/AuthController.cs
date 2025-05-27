using Microsoft.AspNetCore.Mvc;
using GlamLink.Data;
using GlamLink.Models;
using System.Linq;
using System;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AuthController(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] Users loginUser)
    {
        try
        {
            if (loginUser == null || string.IsNullOrWhiteSpace(loginUser.Username) || string.IsNullOrWhiteSpace(loginUser.Password))
                return BadRequest("Username and password are required.");

            var user = _context.Users
                .FirstOrDefault(u => u.Username.ToLower() == loginUser.Username.ToLower()
                                  && u.Password == loginUser.Password);

            if (user == null)
                return Unauthorized("Invalid credentials");

            return Ok(new { message = "User login successful", userId = user.idUser });
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Server error: " + ex.Message);
        }
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] Users newUser)
    {
        try
        {
            if (_context.Users.Any(u => u.Username == newUser.Username))
                return BadRequest("Username already exists");

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return Ok("User registered successfully");
        }
        catch (Exception ex)
        {
            var innerMessage = ex.InnerException?.Message ?? ex.Message;
            return StatusCode(500, $"Internal server error: {innerMessage}");
        }
    }


    [HttpPost("loginadmin")]
    public IActionResult LoginAdmin([FromBody] Admins loginAdmin)
    {
        try
        {
            if (loginAdmin == null || string.IsNullOrWhiteSpace(loginAdmin.Username) || string.IsNullOrWhiteSpace(loginAdmin.Password))
                return BadRequest("Username and password are required.");

            var admin = _context.Admins
                .FirstOrDefault(a => a.Username.ToLower() == loginAdmin.Username.ToLower()
                                  && a.Password == loginAdmin.Password);

            if (admin == null)
                return Unauthorized("Invalid admin credentials");

            return Ok(new { adminId = admin.idAdmin });
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Server error: " + ex.Message);
        }
    }
}
