using System.ComponentModel.DataAnnotations;

namespace GlamLink.Models
{
    public class Outfits
    {
        [Key]
        public int idOutfit{ get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Creation_Date { get; set; }
    }
}
