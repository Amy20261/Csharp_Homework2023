using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Struct
{
    public struct Student
    {
        public string Name;
        public double Chinese;
        public double English;
        public double Math;
        public Student(string name, double chinese, double english, double math)
        {
            Name = name;
            Chinese = chinese;
            English = english;
            Math = math;
        }
    }
}
