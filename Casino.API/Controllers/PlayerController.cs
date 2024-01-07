using AutoMapper;
using Casino.API.Models.Players;
using Casino.BLL.Contracts;
using Casino.BLL.Models.Player;
using Microsoft.AspNetCore.Mvc;

namespace Casino.API.Controllers
{
    [Route("api/casino/player")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

        private readonly IPlayerBLL _playerService;
        private readonly IMapper _mapper;

        public PlayerController(IPlayerBLL playerService, IMapper mapper)
        {
            _playerService = playerService ?? throw new ArgumentNullException(nameof(playerService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddPlayer(AddPlayerApiModel addPlayerModel)
        {
            var player = _mapper.Map<PlayerInputModel>(addPlayerModel);
            var addedPlayer = await _playerService.AddPlayerAsync(player);
            return Ok(addedPlayer);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update(EditPlayerApiModel updatedPlayer)
        {
            var player = _mapper.Map<EditPlayerInputModel>(updatedPlayer);
            var updatePlayer = await _playerService.UpdatePlayerAsync(player);
            return Ok(updatePlayer);
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> GetTransactionTreeAsync(int id)
        {
            var result = await _playerService.DeleteByIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _playerService.GetPlayersAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetById(int id)
        {
            var player = await _playerService.GetPlayerByIdAsync(id);
            return Ok(player);
        }

    }

}
