using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersPart2.Models
{
    internal class Student:Person
    {
        private string _surname;
        private int _point;
        public string Surname{ get; set; }
        public int Point{ get; set; }

        public Student(string surname, int point, string name, int age):base(name, age)
        {
            Surname = surname;
            Point = point;
            Name = name;
            Age = age;
        }

        public void StdInfo()
        {
            Console.WriteLine($"Student Name: {Name} \n" +
                $"Student Surname: {Surname} \n" +
                $"Student Age: {Age} \n" +
                $"Student points: {Point}");
        }

    }

    
}
