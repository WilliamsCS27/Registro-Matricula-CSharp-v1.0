using System;
using System.Collections.Generic;
using System.Text;

namespace STUPS
{
    class Program
    {
        public static AllStruct.Student[] structStudentArray = new AllStruct.Student[2];
        public static AllStruct.Course[] structCourseArray = new AllStruct.Course[2];
        public static AllStruct.Teacher[] structTeachArray = new AllStruct.Teacher[2];
        public static AllStruct.Assignment[] structAssignmentArray = new AllStruct.Assignment[100];

        static void Main(string[] args)
        {
            Menu.CreatMenu();
            //Console.WriteLine("{0}",structStudent[1].name.ToString());
            Console.ReadLine();
        }
    }
}
