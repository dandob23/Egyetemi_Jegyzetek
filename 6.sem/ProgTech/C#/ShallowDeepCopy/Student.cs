using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace ShallowDeepCopy
{
    internal class Student : ICloneable
    {
        public Student() { this.Subjects = new List<string>(); }

        public string Name { get; set; }

        public List<string> Subjects { get; set; }

        public Address Address { get; set; }

        public object Clone()
        {
            Student student = new Student();
            student.Name = this.Name;
            student.Subjects = new List<string>(this.Subjects);
            student.Address = (Address)Address.Clone();
            return student;
        }

        public override string ToString()
        {
            return $"Student[name='{Name}'; subject='{Subjects}'; address ='{Address}']";
        }
    }
}
