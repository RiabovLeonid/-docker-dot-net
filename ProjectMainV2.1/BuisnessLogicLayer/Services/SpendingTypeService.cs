using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BuisnessLogicLayer.DTO;
using BuisnessLogicLayer.Interfaces;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;

namespace BuisnessLogicLayer.Services
{
    public class SpendingTypeService : ISpendingTypeService
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _mapper;
        public SpendingTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddSpendingType(SpendingTypeDTO spendingTypeDTO)
        {
            var x = _mapper.Map<SpendingTypeDTO, Spending_type>(spendingTypeDTO);
            await _UnitOfWork.SpendingTypeRepository.Add(x);
        }
        public async Task DeleteSpendingType(int id)
        {
            await _UnitOfWork.SpendingTypeRepository.Delete(id);
        }

        public async Task<IEnumerable<SpendingTypeDTO>> GetAllSpendingType()
        {
            var x = await _UnitOfWork.SpendingTypeRepository.GetAll();
            return _mapper.Map<IEnumerable<Spending_type>, IEnumerable<SpendingTypeDTO>>(x);
        }

        public async Task<SpendingTypeDTO> GetSpendingTypeById(int Id)
        {
            var x = await _UnitOfWork.SpendingTypeRepository.Get(Id);
            return _mapper.Map<SpendingTypeDTO>(x);
        }

        public async Task UpdateSpendingType(SpendingTypeDTO spendingTypeDTO)
        {
            var x = _mapper.Map<Spending_type>(spendingTypeDTO);
            await _UnitOfWork.SpendingTypeRepository.Update(x);
        }
    }
}