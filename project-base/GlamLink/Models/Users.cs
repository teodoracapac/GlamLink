using System.ComponentModel.DataAnnotations;

namespace GlamLink.Models
{
    public class Users
    {
        [Key]
        public int idUsers { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
