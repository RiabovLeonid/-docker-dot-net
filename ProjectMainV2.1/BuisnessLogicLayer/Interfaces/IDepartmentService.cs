using BuisnessLogicLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Interfaces
{
    public interface IDepartmentService
    {
        Task AddDepartment(DepartmentDTO departmentDTO);
        Task UpdateDepartment(DepartmentDTO departmentDTO);
        Task DeleteDepartment(int Id);
        Task<DepartmentDTO> GetDepartmentById(int Id);
        Task<IEnumerable<DepartmentDTO>> GetAllDepartment();
    }
}