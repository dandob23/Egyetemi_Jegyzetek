using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowDeepCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Dobozy Dani";
            student.Subjects.Add("Progtech");
            student.Subjects.Add("BevGraf");
            student.Subjects.Add("MestInt");
            student.Address= new Address();
            student.Address.City = "Eger";
            student.Address.Street = "valami";

            Console.WriteLine(student);

            Student student2 = student;
            student2.Name = "Valami";
            student2.Subjects.Add("AdatB2");
            
            Console.ReadLine();
        }
    }
}
