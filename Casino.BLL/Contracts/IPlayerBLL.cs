using Casino.BLL.Models.Player;

namespace Casino.BLL.Contracts
{
    public interface IPlayerBLL
    {
        Task<PlayerDTO> AddPlayerAsync(PlayerInputModel player);
        Task<PlayerDTO> GetPlayerByIdAsync(int id);
        Task<List<PlayerDTO>> GetPlayersAsync();
        Task<PlayerDTO> UpdatePlayerAsync(EditPlayerInputModel player);
        Task<bool> DeleteByIdAsync(int id);
    }
}
