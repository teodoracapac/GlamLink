namespace GlamLink.Models
{
    public class UpdateAccountDTO
    {
        public int Id { get; set; }            
        public string NewUsername { get; set; }
        public string NewPassword { get; set; }
        public string AccountType { get; set; }
    }
}
