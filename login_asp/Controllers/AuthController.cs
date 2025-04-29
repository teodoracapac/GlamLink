using Microsoft.AspNetCore.Mvc;
using WebApplicationGlamLink.Data;
using WebApplicationGlamLink.Models;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;

    public AuthController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] Users loginUser)
    {
        var user = _context.Users
            .FirstOrDefault(u => u.Username == loginUser.Username && u.Password == loginUser.Password);

        if (user == null)
            return Unauthorized("Invalid credentials");
        return Ok("Login successful");
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] Users newUser)
    {
        if (_context.Users.Any(u => u.Username == newUser.Username))
            return BadRequest("Username already exists");

        _context.Users.Add(newUser);
        _context.SaveChanges();

        return Ok("User registered successfully");
    }

    [HttpPost("loginadmin")]
    public IActionResult LoginAdmin([FromBody] Admins loginadmin)
    {
        var admin = _context.Admins
            .FirstOrDefault(u => u.Username == loginadmin.Username && u.Password == loginadmin.Password);

        if (admin == null)
            return Unauthorized("Invalid credentials");
        return Ok("Login successful");
    }
}
