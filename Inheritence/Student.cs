using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public double Point;
        public bool IsGraduated;
        public Student(string name, string surname, string group, double point, bool isGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = point >= 65;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{Name} \n{Surname} \n{Group} \n{Point} \n{IsGraduated}");
        }
        public void CheckGraduation()
        {
            if (IsGraduated)
            {
                Console.WriteLine("mezun olub");
            }
            else
            {
                Console.WriteLine("mezun olmayib");
            }
        }
        public void GetDiplomDegree()
        {
            if (Point <65)
            {
                Console.WriteLine("diplom yoxdur");
            }
            else if (Point >=65 &&  Point < 80)
            {
                Console.WriteLine("adi diplom");
            }
            else
            {
                Console.WriteLine("yuksek seref diplomu");
            }
        }
    }
}

