using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_01.Settings
{
    public class ApplicationSettings : Object
    {
        public ApplicationSettings() : base()
        {
        }

        public int Age { get; set; }

        public float Salary { get; set; }

        public bool IsTeacher { get; set; }

        public string FullName { get; set; }

        public Company Company { get; set; }

        public string[] courses { get; set; }
    }
}
