using DataAccessLayer.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Interfaces
{
    public interface IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get; }
        ISpendingRepository SpendingRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }
        ISpendingTypeRepository SpendingTypeRepository { get; }
        ILimitValueRepository LimitValueRepository { get; }
        void Complete();
    }
}
