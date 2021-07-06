using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLib
{
    public class Student
    {
        private readonly string name;

        public Student(string Name)
        {
            name = Name;
        }

        public string Name { get; set; }
    }
}
