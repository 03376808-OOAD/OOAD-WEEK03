using System;

namespace Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point myPoint = new Point();
            myPoint.X = 10;
            myPoint.Y = 10;
            Console.WriteLine("myPoint.X = {0}", myPoint.X);
            Console.WriteLine("myPoint.Y = {0}", myPoint.Y);
            Console.ReadLine();
        }
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
       // get { return y; }
        set { y = value; }
    }
}
