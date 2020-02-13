using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activitylast2
{
    class Program
    {
        static void Main(string[] args)
        {
            TraineeStudent t = new TraineeStudent("60030049", 500);

            try
            {
                Console.WriteLine("Student ID : "+ t.getStudentID);
                Console.WriteLine("Salary : "+t.getSalary +" Bath");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
    class TraineeStudent
    {
        private string studentid;
        private int salary;

        public TraineeStudent(string getStudentID,int getSalary)
        {
            this.studentid = getStudentID;
            this.salary = getSalary;
        }
        public string getStudentID
        {
            get { return studentid; }
        }
        public int getSalary
        {
            get
            {
                return salary;
            }
            /***
            set
            {
                if (value <= 450)
                    salary = value;
                else
                    throw (new Exception("Error!!! invalid Salary"));
            }
            */
        }
    }
}
