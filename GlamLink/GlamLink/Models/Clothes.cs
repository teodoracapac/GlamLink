using System.ComponentModel.DataAnnotations;

namespace GlamLink.Models
{
    public class Clothes
    {
        [Key]
        public int idClothes { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Season { get; set; }
        [Required]
        public int idUser { get; set; }

        public string imageFileName { get; set; }
    }
}
