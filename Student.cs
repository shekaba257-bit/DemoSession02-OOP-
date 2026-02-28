using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSession02_OOP_
{
    internal class Student
    {


        public static int TotalStudent=0;


        public string Name { get; set; }
        public int Id { get; set; }

        // CTOR 
        public Student(string name)
        {
            Name = name;
            Id = TotalStudent;
            TotalStudent++;
        }


    }
}
