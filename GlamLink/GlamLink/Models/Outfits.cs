using System.ComponentModel.DataAnnotations;

namespace GlamLink.Models;
public class Outfits
{
    [Key]
    public int idOutfit { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]

    public DateTime Creation_Date { get; set; }

    public string? DressImage { get; set; }
    public string? TopImage { get; set; }
    public string? BottomImage { get; set; }
    public string? JacketImage { get; set; }
    public string? ShoesImage { get; set; }
    public string? AccessoriesImage { get; set; }

    public override string ToString() => Name;

    public int idUser { get; set; }

}
