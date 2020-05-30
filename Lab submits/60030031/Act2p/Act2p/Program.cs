using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2p
{
    class Program
    {
        static void Main(string[] args)
        {
            TraineeStudent su = new TraineeStudent("600300",300);
            try
            {
                
                su.SA = 320;
                Console.WriteLine("Student ID   : " + su.ID);
                Console.WriteLine("Salary : " + su.SA);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
    class TraineeStudent
    {
        private string id;
        public int sa;

        public TraineeStudent(string ID,int SA)
        {
            this.id = ID;
            this.sa = SA;      }
        public string ID
        {
            get { return id; }
        }
        public int SA
        {
            get
            {
                return sa;
            }
            set
            {

                if (value > 300 && value <= 450)
                    sa = value;
                else
                    throw (new Exception("Invilid Salary "));
            }
        }
    }
}
