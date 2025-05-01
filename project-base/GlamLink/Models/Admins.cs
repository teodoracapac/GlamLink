using System.ComponentModel.DataAnnotations;
namespace GlamLink.Models
{
    public class Admins
    {
        [Key]
        public int idAdmin { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
