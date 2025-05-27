namespace GlamLink.Models
{
    public class EventsDTO
    {
        public int idEvent { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int idOutfit { get; set; } 
        public int idUser { get; set; }
        public string OutfitName { get; set; }
    }
}
