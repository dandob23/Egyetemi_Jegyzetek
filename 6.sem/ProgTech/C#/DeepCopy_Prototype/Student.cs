using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy_Prototype
{
    internal class Student:IPrototype<Student>
    {
        public Student() { this.Subjects = new List<string>(); }

        public string Name { get; set; }

        public List<string> Subjects { get; set; }

        public Address Address { get; set; }

        public Student DeepCopy()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Student[name='{Name}'; subject='{Subjects}'; address ='{Address}']";
        }
    }
}
