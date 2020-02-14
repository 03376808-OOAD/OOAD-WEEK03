using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practices1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SayHi();
            Student s = new Student();
            s.SayHi();
            Person sp = new Student();
            sp.SayHi();
            Teacher t = new Teacher();
            t.SayHi();
            Person tp = new Teacher();
            tp.SayHi();
            Person o = new Teacher();
            tp.SayHi();
           
            
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
        class Student : Person
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi I'm a student");
        }
    }
    class Teacher : Person
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi I'm a teacher");
        }
    }
    class Professor : Teacher
    {
        public new void SayHi()
        {
            Console.WriteLine("Hi I'm a teacher");
        }
    }
}
