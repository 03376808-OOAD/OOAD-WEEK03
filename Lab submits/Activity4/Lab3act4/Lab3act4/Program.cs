using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3act4
{
    class Program
    {
        void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
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
            Console.ReadKey();
        }
    }
    class Vector
    {
        public Vector(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; } 
        public int Y { get; set; }
        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator -(Vector v1)
        {
            return new Vector(-v1.X, -v1.Y);
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
}
