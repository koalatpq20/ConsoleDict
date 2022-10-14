using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDict
{
    public class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Information
        {
            get => $"Nhan vien {Name} - ID {ID} - Tuoi {Age}";
        }
    }
}
