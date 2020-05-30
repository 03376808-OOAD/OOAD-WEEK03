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
            Person t = new Person();
            t.SayHi();
            Console.ReadKey();
        }
    }
}
class Person
{
    public virtual void SayHi()
    {
        Console.WriteLine("Hi I'm a person");
    }
}

class Student : Person
{
    public override void SayHi()
    {
        Console.WriteLine("Hi I'm a student");
    }
}

class Teacher : Person
{
    public new void SayHi()
    {
        Console.WriteLine("Hi I'm a teacher");
    }
}
class Professor : Teacher
{
    public new void SayHi()
    {
        Console.WriteLine("Hi I'm a Professor");
    }
}