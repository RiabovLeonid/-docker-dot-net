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
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _mapper;
        public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddEmployee(EmployeeDTO employeeDTO)
        {
            var x = _mapper.Map<EmployeeDTO,Employee>(employeeDTO);
            await _UnitOfWork.EmployeeRepository.Add(x);
        }
        public async Task DeleteEmployee(int id)
        {
           await _UnitOfWork.EmployeeRepository.Delete(id);
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAllEmployee()
        {
            var x = await _UnitOfWork.EmployeeRepository.GetAll();
            return _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDTO>>(x);
        }

        public async Task<EmployeeDTO> GetEmployeeById(int Id)
        {
            var x= await _UnitOfWork.EmployeeRepository.Get(Id);
            return _mapper.Map<EmployeeDTO>(x);
        }

        public async Task UpdateEmployee(EmployeeDTO employeeDTO)
        {
            var x = _mapper.Map<Employee>(employeeDTO);
            await _UnitOfWork.EmployeeRepository.Update(x);
        }
    }
}
