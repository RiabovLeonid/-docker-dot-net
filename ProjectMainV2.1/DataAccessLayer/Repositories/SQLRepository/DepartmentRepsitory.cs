using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories.SQLRepository
{
    public class DepartmentRepository : GenericRepository<Department, int>, IDepartmentRepository
    {
        public DepartmentRepository(MyDbContext myDbContext) : base(myDbContext) { }
    }
}
