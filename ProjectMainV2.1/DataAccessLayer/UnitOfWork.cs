using DataAccessLayer.Interfaces;
using DataAccessLayer.Interfaces.RepositoryInterfaces;
using System;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ISpendingRepository _spendingRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILimitValueRepository _limitValueRepository;
        private readonly ISpendingTypeRepository _spendingTypeRepository;
        public UnitOfWork(IEmployeeRepository employeeRepository,
                          ISpendingRepository spendingRepository,
                          IDepartmentRepository departmentRepository,
                          ILimitValueRepository limitValueRepository,
                          ISpendingTypeRepository spendingTypeRepository)
        {
            _employeeRepository = employeeRepository;
            _spendingRepository = spendingRepository;
            _departmentRepository = departmentRepository;
            _limitValueRepository = limitValueRepository;
            _spendingTypeRepository = spendingTypeRepository;
        }
        public IEmployeeRepository EmployeeRepository
        {
            get
            {
                return _employeeRepository;
            }
        }
        public IDepartmentRepository DepartmentRepository
        {
            get
            {
                return _departmentRepository;
            }
        }
        public ISpendingRepository SpendingRepository
        {
            get
            {
                return _spendingRepository;
            }
        }
        public ISpendingTypeRepository SpendingTypeRepository
        {
            get
            {
                return _spendingTypeRepository;
            }
        }
        public ILimitValueRepository LimitValueRepository
        {
            get
            {
                return _limitValueRepository;
            }
        }
        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
