using BuisnessLogicLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Interfaces
{
    public interface IEmployeeService
    {
        Task AddEmployee(EmployeeDTO employee);
        Task UpdateEmployee(EmployeeDTO employee);
        Task DeleteEmployee(int Id);
        Task<EmployeeDTO> GetEmployeeById(int Id);
        Task<IEnumerable<EmployeeDTO>> GetAllEmployee();
    }
}
