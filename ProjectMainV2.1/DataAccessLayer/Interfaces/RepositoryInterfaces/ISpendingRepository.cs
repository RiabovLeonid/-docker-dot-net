using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces.RepositoryInterfaces
{
    public interface ISpendingRepository : IGenericRepository<Spending, int>
    {
    }
}
