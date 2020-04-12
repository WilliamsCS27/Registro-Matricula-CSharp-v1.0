using System;
using System.Collections.Generic;
using System.Text;

namespace STUPS
{
    class AllStruct
    {
        public AllStruct()
        {
            //Constructor de la clase AllStruct
        }
        public struct Student
        {
            public string studentID;
            public string name;
            public string lastname;
            public string address;
        }
        public struct Course
        {
            public string courseID;
            public string courseName;
        }
        public struct Teacher
        {
            public string teacherID;
            public string teacherName;
        }
        public struct Assignment
        {
            public string stuID;
            public string lessonID;
            public string teacherID;
        }
    }
}
