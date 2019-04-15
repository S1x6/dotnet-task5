using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTask4.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int Money { get; set; }
    }
}
