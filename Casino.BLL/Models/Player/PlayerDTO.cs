
namespace Casino.BLL.Models.Player
{
    public class PlayerDTO
    {
        public int Id { get; set; } 
        public string Email { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public int Salt { get; set; }

        public byte Gender { get; set; }

        public byte State { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? MobileNumber { get; set; }
    }
}
