using BuisnessLogicLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Interfaces
{
    public interface ISpendingTypeService
    {
        Task AddSpendingType(SpendingTypeDTO spendingTypeDTO);
        Task UpdateSpendingType(SpendingTypeDTO spendingTypeDTO);
        Task DeleteSpendingType(int Id);
        Task<SpendingTypeDTO> GetSpendingTypeById(int Id);
        Task<IEnumerable<SpendingTypeDTO>> GetAllSpendingType();
    }
}
