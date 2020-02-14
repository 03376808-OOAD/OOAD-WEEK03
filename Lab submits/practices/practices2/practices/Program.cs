using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practices
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Professor();
            p.SayHi();
            Console.ReadKey();
        }
    }
    class Person
    {
        public virtual void SayHi()
        {
            Console.WriteLine("Hi I'm a person");
        }
    }
    class Professor : Person
    {
        public virtual void SayHi()
        {
            Console.WriteLine("Hi I'm a Professor");
        }
    }
}
