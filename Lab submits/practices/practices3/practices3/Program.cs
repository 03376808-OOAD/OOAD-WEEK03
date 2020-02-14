using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practices3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Professor();
            p.SayHi();
            Console.ReadKey();
        }
    }
    class Student
    {
        public new void SayHi()
        {
            Console.WriteLine("Hi I'm a student");
        }
    }
    class Professor : Student
    {
        public new void SayHi()
        {
            Console.WriteLine("Hi I'm a Professor");
        }
    }
}
