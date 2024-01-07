namespace Casino.BLL.Models.Player
{
    public  class PlayerInputModel
    {
        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public byte Gender { get; set; }

        public byte State { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? MobileNumber { get; set; }
    }
}
