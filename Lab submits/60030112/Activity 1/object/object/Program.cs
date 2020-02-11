using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @object
{
    class Program
    {
        static void Main(string[] args)
        {
            Point myPoint = new Point();
            myPoint.X = 10;
            myPoint.Y = 10;
            Console.WriteLine("myPoint.x = {0}", myPoint.X);
            Console.WriteLine("myPoint.y = {0}", myPoint.Y);
        }
    }
    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
