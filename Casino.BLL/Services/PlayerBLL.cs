using AutoMapper;
using Casino.BLL.Common;
using Casino.BLL.Contracts;
using Casino.BLL.Models.Player;
using Casino.DAL.EntityModels;
using Casino.DAL.Repositories.PlayerRepository;
using Microsoft.EntityFrameworkCore;

namespace Casino.BLL.Services
{
    public class PlayerBLL : IPlayerBLL
    {
        private IPlayerRepository _playerRepository;
        private IMapper _mapper;
        public PlayerBLL(IMapper mapper,
            IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public async Task<PlayerDTO> AddPlayerAsync(PlayerInputModel player)
        {
            var dbPlayer = _mapper.Map<Player>(player);
            int salt = CommonFunctions.GenerateSalt();
            dbPlayer.Salt = salt;
            dbPlayer.PasswordHash = CommonFunctions.HashPasswordAndSetSalt(player.Password, salt);
            var addedPlayer = await _playerRepository.AddAsync(dbPlayer);
            
            // also add Accounts for player here
            // there are 2 accounts for a specific Player, one is for counting Bonuses,
            // Second is for counting real money
            return _mapper.Map<PlayerDTO>(addedPlayer);
        }

        public async Task<PlayerDTO> GetPlayerByIdAsync(int id)
        {
            var dbPlayer = await _playerRepository.GetByIdAsync(id);
            if (dbPlayer == null)
                throw new Exception("Player was not found");
            var result = _mapper.Map<PlayerDTO>(dbPlayer);
            return result;
        }

        public async Task<List<PlayerDTO>> GetPlayersAsync()
        {
            var result = await _playerRepository.GetAll().ToListAsync();
            return _mapper.Map<List<PlayerDTO>>(result);
        }

        public async Task<PlayerDTO> UpdatePlayerAsync(EditPlayerInputModel player)
        {
            var dbPlayer = await _playerRepository.GetByIdAsync(player.Id);
            if (dbPlayer == null)
                throw new Exception("Player was not found");
            dbPlayer.State = player.State;

            // all the updates here ........

            _playerRepository.Update(dbPlayer);
            var updatedDbPlayer = await _playerRepository.GetByIdAsync(player.Id);
            var result = _mapper.Map<PlayerDTO>(updatedDbPlayer);
            return result;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var dbPlayer = await _playerRepository.GetByIdAsync(id);
            if (dbPlayer == null)
                throw new Exception("Player was not found");

            await _playerRepository.DeleteAsync(dbPlayer);
            return true;

        }
        private async Task AddAccountsForPlayerAsync(int playerId)
        {
            // add accounts for player
        }

    }
}
