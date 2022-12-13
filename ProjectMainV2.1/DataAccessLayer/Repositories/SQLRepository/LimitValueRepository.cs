using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Interfaces.RepositoryInterfaces;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories.SQLRepository
{
    public class LimitValueRepository : GenericRepository<LimitValue, int>, ILimitValueRepository
    {
        public LimitValueRepository(MyDbContext myDbContext) : base(myDbContext) { }
    }
}
