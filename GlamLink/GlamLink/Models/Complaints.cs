using System.ComponentModel.DataAnnotations;

namespace GlamLink.Models
{
    public class Complaints
    {
        [Key]
        public int idComplaint { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string Status { get; set; } = "Pending";

        [Required]
        public int idUser { get; set; }
        [Required]
        public int idAdmin { get; set; }

        public Users User { get; set; }
        public Admins Admin { get; set; }

    }
}
