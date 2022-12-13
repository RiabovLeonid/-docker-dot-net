using DataAccessLayer.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Employee : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public int Id_Dep { get; set; }
        public Department Department { get; set; }
        public int Salary { get; set; }
    }
}
