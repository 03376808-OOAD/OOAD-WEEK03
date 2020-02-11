using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Tom", 350f);
            Console.WriteLine("{0} charge = {1}", teacher.TypeName(), teacher.CalculateCharge(20f));
            Console.ReadLine();
        }
    }
    class Teacher
    {
        public Teacher(string name, float billingRate)
        {
            this.name = name;
            this.billingRate = billingRate;
        }
        public float CalculateCharge(float hours)
        {
            return (hours * billingRate);
        }
        public string TypeName()
        {
            return ("Teacher");
        }
        private string name;
        protected float billingRate;
    }
}
