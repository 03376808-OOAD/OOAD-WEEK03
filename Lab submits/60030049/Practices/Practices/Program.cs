using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            Person t = new Teacher();
            t.SayHi();
            Console.ReadKey();
        }
    }
    class Person
    {
        public virtual void SayHi()
        {
            Console.WriteLine("Hi Person");
        }
    }
    class Student:Person
    {
        public override void SayHi()
        {
            Console.WriteLine("Student");
        }
    }
    class Teacher:Person
    {
        public override void SayHi()
        {
            Console.WriteLine("Teacher");
        }
    }
    class Professor : Teacher
    {
        public new void SayHi()
        {
            Console.WriteLine("Professor");
        }
    }
}
