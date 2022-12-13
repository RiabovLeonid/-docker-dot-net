using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Interfaces.RepositoryInterfaces;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories.SQLRepository
{
    public class SpendingTypeRepository : GenericRepository<Spending_type, int>, ISpendingTypeRepository
    {
        public SpendingTypeRepository(MyDbContext myDbContext) : base(myDbContext) { }
    }
}
