﻿using System;

namespace LabWk3_Act2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TraineeStudent std1 = new TraineeStudent("60030037", 451);
                Console.WriteLine("Std ID : " + std1.getStudentID());
                Console.WriteLine("Salary : " + std1.getSalary());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

            Student su = new Student("Student Name","12345678");
            try
            {
                //su.Name = "Student Name";
                su.GPA = 7.5f;
                Console.WriteLine("Student name : " + su.Name);
                Console.WriteLine("Student ID : " + su.ID);
                Console.WriteLine("Student GPA : " + su.GPA);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }

    class Student
    {
        private string name;
        private string id;
        private float gpa;

        public Student(string Name,string ID)
        {
            this.name = Name;
            this.id = ID;
        }

        public string Name
        {
            get { return name; }
        }

        public string ID
        {
            get { return id; }
        }
        public float GPA
        {
            get { return gpa; }
            set
            {
                if (value > 0.0 && value <= 4.0) gpa = value;
                else throw (new Exception("Error!!!! invalid GPA"));
            }
        }
    }

    class TraineeStudent
    {
        private string StudentID;
        private float salary;

        public TraineeStudent(string stdID,float sal)
        {
            this.StudentID = stdID;
            if (sal >= 300 && sal <= 450)
            {
                this.salary = sal;
            } else throw (new Exception("Error!!! Invalid Salary Amount"));
        }

        public float getSalary()
        {
            return this.salary;
        }

        public string getStudentID()
        {
            return this.StudentID;
        }
    }
}
