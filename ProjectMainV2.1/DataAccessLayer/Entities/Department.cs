using DataAccessLayer.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Department : IEntity<int>
    {
        public int Id { get; set; }
        public string Depart_name { get; set; }
        public int Employee_count { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<LimitValue> LimitValues { get; set; }
        public IEnumerable<Spending> Spendings { get; set; }
    }
}
