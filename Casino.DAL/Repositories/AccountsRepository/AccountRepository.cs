using Casino.DAL.EntityModels;


namespace Casino.DAL.Repositories.AccountsRepository
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        public AccountRepository(CasinoContext dbContext) : base(dbContext)
        {
        }
    }
}
