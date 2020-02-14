using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLab3act2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentID a = new StudentID("60030089");try
            {
                a.getSalary = 500;
                Console.WriteLine("Your StudentID is : " + a.getStudentID);
                Console.WriteLine("Your Salary is : " + a.getSalary);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
    class StudentID
    {
        private string id;
        private int b;

        public StudentID(string StudentID)
        {
            this.id = StudentID;
        }
        public string getStudentID
        {
            get { return id; }
        }
        public int getSalary
        {
            get { return b; }
            set 
            {
                if (value > 300 && value <= 450)
                    b = value;
                else
                    throw (new Exception("Invalid !!!!!!!"));
            }
        }
    }
}
