using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BuisnessLogicLayer.DTO;
using BuisnessLogicLayer.Interfaces;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;

namespace BuisnessLogicLayer.Services
{
    public class SpendingService : ISpendingService
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _mapper;
        public SpendingService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddSpending(SpendingDTO spendingDTO)
        {
            var x = _mapper.Map<SpendingDTO, Spending>(spendingDTO);
            await _UnitOfWork.SpendingRepository.Add(x);
        }
        public async Task DeleteSpending(int id)
        {
            await _UnitOfWork.SpendingRepository.Delete(id);
        }

        public async Task<IEnumerable<SpendingDTO>> GetAllSpending()
        {
            var x = await _UnitOfWork.SpendingRepository.GetAll();
            return _mapper.Map<IEnumerable<Spending>, IEnumerable<SpendingDTO>>(x);
        }

        public async Task<SpendingDTO> GetSpendingById(int Id)
        {
            var x = await _UnitOfWork.SpendingRepository.Get(Id);
            return _mapper.Map<SpendingDTO>(x);
        }

        public async Task UpdateSpending(SpendingDTO spendingDTO)
        {
            var x = _mapper.Map<Spending>(spendingDTO);
            await _UnitOfWork.SpendingRepository.Update(x);
        }
    }
}