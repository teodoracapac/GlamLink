using System.ComponentModel.DataAnnotations;

namespace GlamLink.Models
{
    public class OutfitClothes
    {
        [Key]
        public int idOutfitClothes { get; set; }
        [Required]
        public int idOutfit { get; set; }
        [Required]
        public int idClothes { get; set; }
        public virtual Outfits Outfit { get; set; } 
        public virtual Clothes Clothes { get; set; }

    }
}
