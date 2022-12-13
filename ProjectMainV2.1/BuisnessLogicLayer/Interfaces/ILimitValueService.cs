using BuisnessLogicLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Interfaces
{
    public interface ILimitValueService
    {
        Task AddLimitValue(LimitValueDTO limitValueDTO);
        Task UpdateLimitValue(LimitValueDTO limitValueDTO);
        Task DeleteLimitValue(int Id);
        Task<LimitValueDTO> GetLimitValueById(int Id);
        Task<IEnumerable<LimitValueDTO>> GetAllLimitValue();
    }
}