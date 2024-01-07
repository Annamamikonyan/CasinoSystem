
namespace Casino.BLL.Models.Player
{
    public class EditPlayerInputModel
    {
        public int Id { get; set; }
        public string Email { get; set; } 
        public string UserName { get; set; }
        public byte Gender { get; set; }
        public byte State { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobileNumber { get; set; }
    }
}
