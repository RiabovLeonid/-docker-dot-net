using BuisnessLogicLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Interfaces
{
    public interface ISpendingService
    {
        Task AddSpending(SpendingDTO spending);
        Task UpdateSpending(SpendingDTO spending);
        Task DeleteSpending(int Id);
        Task<SpendingDTO> GetSpendingById(int Id);
        Task<IEnumerable<SpendingDTO>> GetAllSpending();
    }
}
