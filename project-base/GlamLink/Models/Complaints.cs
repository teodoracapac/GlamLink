using System.ComponentModel.DataAnnotations;

namespace GlamLink.Models
{
    public class Complaints
    {
        [Key]
        public int idComplaints { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Text { get; set; }

    }
}
