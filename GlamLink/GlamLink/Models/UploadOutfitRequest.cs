namespace GlamLink.Models
{
    public class UploadOutfitRequest
    {
        public string Name { get; set; }
        public DateTime? Creation_Date { get; set; }
        public IFormFile File { get; set; }

        public List<int> SelectedClothingIds { get; set; }
    }
}
