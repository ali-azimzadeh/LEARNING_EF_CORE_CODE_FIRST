using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_01.Settings
{
    public class Company : Object
    {
        public Company() : base()
        {
        }

        public string CompanyName { get; set; }

        public int EmployeeCount { get; set; }
    }
}
