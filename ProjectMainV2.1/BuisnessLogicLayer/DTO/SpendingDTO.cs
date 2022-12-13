using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogicLayer.DTO
{
    public class SpendingDTO
    {
        public int Id { get; set; }
        public int Id_Dep { get; set; }
        public int Id_Spend_type { get; set; }
        public DateTime DateT { get; set; }
        public int Summa { get; set; }
    }
}
