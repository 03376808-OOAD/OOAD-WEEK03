using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practices4
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Person();
            t.SayHi();
            Console.ReadKey();
        }
    }
    class Person : Teacher
    {
        public virtual void SayHi()
        {
            Console.WriteLine("Hi I'm a person");
        }
    }
    class Teacher 
    {
        public new void SayHi()
        {
            Console.WriteLine("Hi I'm a teacher");
        }
    }
}
