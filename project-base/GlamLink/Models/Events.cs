using System.ComponentModel.DataAnnotations;

namespace GlamLink.Models
{
    public class Events
    {
        [Key]
        public int idEvents { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Date { get; set; }
    }
}
