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
    public class LimitValueService : ILimitValueService
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _mapper;
        public LimitValueService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddLimitValue(LimitValueDTO limitValueDTO)
        {
            var x = _mapper.Map<LimitValueDTO, LimitValue>(limitValueDTO);
            await _UnitOfWork.LimitValueRepository.Add(x);
        }
        public async Task DeleteLimitValue(int id)
        {
            await _UnitOfWork.LimitValueRepository.Delete(id);
        }

        public async Task<IEnumerable<LimitValueDTO>> GetAllLimitValue()
        {
            var x = await _UnitOfWork.LimitValueRepository.GetAll();
            return _mapper.Map<IEnumerable<LimitValue>, IEnumerable<LimitValueDTO>>(x);
        }

        public async Task<LimitValueDTO> GetLimitValueById(int Id)
        {
            var x = await _UnitOfWork.LimitValueRepository.Get(Id);
            return _mapper.Map<LimitValueDTO>(x);
        }

        public async Task UpdateLimitValue(LimitValueDTO limitValueDTO)
        {
            var x = _mapper.Map<LimitValue>(limitValueDTO);
            await _UnitOfWork.LimitValueRepository.Update(x);
        }
    }
}