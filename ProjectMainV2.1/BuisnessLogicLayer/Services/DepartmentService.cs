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
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _mapper;
        public DepartmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddDepartment(DepartmentDTO departmentDTO)
        {
            var x = _mapper.Map<DepartmentDTO, Department>(departmentDTO);
            await _UnitOfWork.DepartmentRepository.Add(x);
        }
        public async Task DeleteDepartment(int id)
        {
            await _UnitOfWork.DepartmentRepository.Delete(id);
        }

        public async Task<IEnumerable<DepartmentDTO>> GetAllDepartment()
        {
            var x = await _UnitOfWork.DepartmentRepository.GetAll();
            return _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentDTO>>(x);
        }

        public async Task<DepartmentDTO> GetDepartmentById(int Id)
        {
            var x = await _UnitOfWork.DepartmentRepository.Get(Id);
            return _mapper.Map<DepartmentDTO>(x);
        }

        public async Task UpdateDepartment(DepartmentDTO departmentDTO)
        {
            var x = _mapper.Map<Department>(departmentDTO);
            await _UnitOfWork.DepartmentRepository.Update(x);
        }
    }
}