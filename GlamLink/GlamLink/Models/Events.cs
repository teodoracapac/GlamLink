using System.ComponentModel.DataAnnotations;

namespace GlamLink.Models
{
    public class Events
    {
        [Key]
        public int idEvent { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int idOutfit { get; set; }
        [Required]
        public int idUser { get; set; }

    }
}
