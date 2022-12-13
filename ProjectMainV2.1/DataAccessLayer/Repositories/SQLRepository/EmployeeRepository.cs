using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Interfaces.RepositoryInterfaces;
using DataAccessLayer.Entities;
namespace DataAccessLayer.Repositories.SQLRepository
{
    public class EmployeeRepository : GenericRepository<Employee, int>, IEmployeeRepository
    {
        public EmployeeRepository(MyDbContext myDbContext) : base(myDbContext) { }
    }
}
