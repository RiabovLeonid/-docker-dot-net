using DataAccessLayer.Interfaces.EntityInterfaces;
using System;

namespace DataAccessLayer.Entities
{
    public class Spending : IEntity<int>
    {
        public int Id { get; set; }
        public int Id_Dep { get; set; }
        public int Id_Spend_type { get; set; }
        public DateTime DateT { get; set; }
        public int Summa { get; set; }
        public Spending_type Spending_type { get; set; }
        public Department Department { get; set; }
    }
}
