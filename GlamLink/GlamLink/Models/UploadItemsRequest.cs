using Microsoft.AspNetCore.Http;

namespace GlamLink.Models
{
    public class UploadItemRequest
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public IFormFile File { get; set; }
        public int idUser { get; set; }
    }
}
