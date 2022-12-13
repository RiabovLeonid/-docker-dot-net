using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front.Services
{
    public interface ISpendingService
    {
        Task<IEnumerable<Spending>> GetSpendings();
    }
}
