using DataAccessLayer.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class LimitValue : IEntity<int>
    {
        public int Id { get; set; }
        public int Id_Dep { get; set; }
        public int Id_Spend_type { get; set; }
        public int Limit_value_in_order { get; set; }
        public Department Department { get; set; }
        public Spending_type Spending_type { get; set; }
    }
}
