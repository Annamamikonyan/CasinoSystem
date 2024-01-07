using Casino.DAL.EntityModels;

namespace Casino.DAL.Repositories.TransactionRepository
{
    internal class PlayerTransactionRepository : BaseRepository<PlayerTransaction>, IPlayerTransactionrepository
    {
        public PlayerTransactionRepository(CasinoContext dbContext) : base(dbContext)
        {
        }
    }
}
