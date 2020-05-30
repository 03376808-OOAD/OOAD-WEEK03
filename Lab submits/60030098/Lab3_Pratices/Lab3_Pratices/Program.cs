using System;

namespace Lab3_Pratices
{
    class Program
    {
        static void Main(string[] args)
        {
            TraineeStudent s = new TraineeStudent("60030098");
            try
            {
                s.getSalary = 470;
                Console.WriteLine("Your StudentID is : " + s.getStudentID);
                Console.WriteLine("Your Salary is : " + s.getSalary);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
    class TraineeStudent
    {
        private string id;
        private int sa;

        public TraineeStudent (string StudentID)
        {
            this.id = StudentID;
        }
        public string getStudentID
        {
            get { return id; }
        }
        public int getSalary
        {
            get { return sa; }
            set
            {
                if (value > 300 && value <= 450)
                    sa = value;
                else
                    throw (new Exception("Invalid salary !!!"));
            }
        }
    }
}
