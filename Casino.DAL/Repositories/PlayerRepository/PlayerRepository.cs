using Casino.DAL.EntityModels;


namespace Casino.DAL.Repositories.PlayerRepository
{
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(CasinoContext dbContext) : base(dbContext)
        {
        }
    }
}
