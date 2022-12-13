using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogicLayer.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public int Id_Dep { get; set; }
        public int Salary { get; set; }
    }
}
