using System;

namespace Act2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            TraineeStudent su = new TraineeStudent("12345678",300);
            Console.WriteLine("Student ID : " + su.getStudentID);
            Console.WriteLine("Student ID : " + su.getSalary);
            Console.ReadLine();
        }
    }
}
class TraineeStudent
{
    private string StudentID;
    private int salary;

    public TraineeStudent (string getStudentID,int getSalary)
    {
        this.StudentID = getStudentID;
        this.salary = getSalary;
    }
    public string getStudentID
    {
        get { return StudentID;}
    }
    public int getSalary
    {
        get { return salary; }
    }
}