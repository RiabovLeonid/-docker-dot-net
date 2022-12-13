using DataAccessLayer.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Spending_type : IEntity<int>
    {
        public int Id { get; set; }
        public string Spending_name { get; set; }
        public string Description { get; set; }
        public IEnumerable<LimitValue> LimitValues { get; set; }
        public IEnumerable<Spending> Spendings { get; set; }
    }
}
