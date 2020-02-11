using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Tom", 350f);
            // teacher work for 20Hr/month
            Professor prof = new Professor("Jerry", 500f, 5000f);

            Console.WriteLine("{0} charge = {1}", teacher.TypeName(), teacher.CalculateCharge(20f));
            Console.ReadLine();
            Console.WriteLine("{0} charge = {1}", prof.TypeName(), prof.CalculateCharge(12F));
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
        // return the name of this type
        public string TypeName()
        {
            return ("Teacher");
        }
        private string name;
        protected float billingRate;
    }
    class Professor : Teacher
    {
        private float emolument;

        public Professor(string name, float billingRate) : base(name, billingRate)
        {

        }
        public Professor(string name,float billingRate,float emolument)
            : this(name,billingRate)
        {
            this.emolument = emolument;
        }

        public new float CalculateCharge(float hours)
        {
            if (hours < 1.0F)
                hours = 1.0F;
            return (hours * billingRate) + emolument;
        }

        public new string TypeName()
        {
            return ("Professor");
        }
    }
}
