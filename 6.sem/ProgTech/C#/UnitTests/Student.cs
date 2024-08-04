using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class Student
    {

        public const string UNIVERSITY = "Eszterházy Károly Katolikus Egyetem";

        public Student(int givenName, int familyName, DateTime dateOfBirth)
        {
            GivenName = givenName;
            FamilyName = familyName;
            DateOfBirth = dateOfBirth;
        }

        private List<int> grades = new List<int>();
        public List<int> Grades
        {
            get { return new List<int>(this.grades); }
        }

        public static int GetGradeByPercentage(int percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                throw new ArgumentException();
            }
            if (percentage < 60)
            {
                return 1;
            }
            if (percentage < 70)
            {
                return 2;
            }
            if (percentage < 80)
            {
                return 3;
            }
            if (percentage < 90)
            {
                return 4;
            }
            return 5;
        }

        public void AddResult(int percentage)
        {
            this.grades.Add(GetGradeByPercentage(percentage));
        }

        private int givenName;
        public int GivenName
        {
            get { return givenName; }
            set { givenName = value; }
        }

        private int familyName;
        public int FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }

        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set 
            {
                if (value.Year > DateTime.Now.Year -10)
                {
                    throw new DateOfBirthLateException();
                }
                dateOfBirth = value; 
            }
        }

        public string FullName
        {
            get
            {
                return $"{givenName} {familyName}";
            }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - dateOfBirth.Year;
            }
        }

    }
}
