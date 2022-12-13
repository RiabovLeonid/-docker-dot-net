using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.RepositoryInterfaces;

namespace DataAccessLayer.Repositories.SQLRepository
{
    public class SpendingRepository : GenericRepository<Spending, int>, ISpendingRepository
    {
        public SpendingRepository(MyDbContext myDbContext) : base(myDbContext) { }
    }
}
