using System;
using System.Collections.Generic;
using System.Text;

namespace STUPS
{
    class Register
    {
        public STUW()
        {
            //Constructor de la clase Register
        }
        public static AllStruct.Student[] studentData(AllStruct.Student[] structStudent)
        {
            Console.Clear(); // consola en blanco
            Console.CursorVisible = true; // desaparece cursor
            int condition = 1;
            bool bound = true;
            int i = 0;
            while (1 == condition && bound)
            {
                Console.CursorVisible = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Codigo del estudiante : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structStudent[i].studentID = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Nombres : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structStudent[i].name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Apellidos : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structStudent[i].address = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Dirección : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structStudent[i].address = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (i < (structStu.Length -1))
                {
                    i++;
                    bound = true;
                }
                else
                {
                    bound = false;
                }
                Question(ref condition);
            }
            return structStudent;
        }
        public static AllStruct.Course[] courseData(AllStruct.Course[] structCourse)
        {
            Console.Clear();
            Console.CursorVisible = true;
            int condition = 1;
            bool bound = true;
            int i = 0;
            while (1 == condition && bound)
            {
                Console.CursorVisible = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Codigo del curso : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structLes[i].courseID = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Nombre del curso : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structLes[i].lcourseName= Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (i < (structLes.Length - 1))
                {
                    i++;
                    bound = true;
                }
                else
                {
                    bound = false;
                }
                Question(ref condition);
            }
            return structCourse;
        }
        public static AllStruct.Teacher[] teacherData(AllStruct.Teacher[] structTeach)
        {
            Console.Clear();
            Console.CursorVisible = true;
            int condition = 1;
            bool bound = true;
            int i = 0;
            while (1 == condition && bound)
            {
                Console.CursorVisible = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Codigo del docente : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structTeach[i].teacherID = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Nombre del docente : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structTeach[i].teacherName = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (i < (structTeach.Length - 1))
                {
                    i++;
                    bound = true;
                }
                else
                {
                    bound = false;
                }
                Question(ref condition);
            }
            return structTeach;
        }
        public static AllStruct.Assignment[] AssignmentData(AllStruct.Assignment[] structAssignment)
        {
            Console.Clear();
            InfoBoard();
            int i = -1;
            int condition = 1;
            while (1 == condition)
            {
                i++;
                Console.CursorVisible = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Codigo del estudiante : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structAssignment[i].studentID = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Codigo del curso : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structAssignment[i].courseID = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Codigo del docente : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structAssignment[i].teacherID = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Question(ref condition);
            }
            return structAssignment;
        }

        public static void InfoBoard()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n {0}   {1} \n","Codigo del curso","Nombre del curso");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Program.structCourseArray.Length; i++)
            {
                Console.WriteLine("\n {0}   {1} \n",Program.structCourseArray[i].courseID,Program.structCourseArray[i].courseName);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n========================================\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n {0}   {1} \n", "Codigo del docente", "Nombre del docente");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int j = 0; j < Program.structTeachArray.Length; j++)
            {
                Console.WriteLine("\n {0}   {1} \n", Program.structTeachArray[j].teacherID, Program.structTeachArray[j].teacherName);
            }
        }

        public static void Question(ref int condition)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n ¿Asignar mas registros? (S/N) \n");
            string keyEnter = Console.ReadKey().KeyChar.ToString().ToUpper();
            if (keyEnter == "S")
            {
                condition = 1;
            }
            else if (keyEnter == "N")
            {
                condition = 0;
            }
            else
            {
                Console.Beep();
                Question(ref condition); 
            }
        }

        public static void showInformation() // Mostrar registros
        {
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Codigo del estudiante : \n");
            Console.ForegroundColor = ConsoleColor.White;
            string studentID = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < Program.structStudentArray.Length; i++)
            {
                if (studentID == Program.structStudentArray[i].studentID)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Codigo del estudiante : {0}\n",Program.structStudentArray[i].studentID);
                    Console.WriteLine("\n Nombres del estudiante : {0}\n", Program.structStudentArray[i].name);
                    Console.WriteLine("\n Apellidos del estudiante : {0}\n", Program.structStudentArray[i].lastname);
                    Console.WriteLine("\n Dirección del estudiante : {0}\n", Program.structStudentArray[i].address);
                }
            }
            Console.WriteLine("\n========================================\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n {0}   {1} \n", "Nombre del curso", "Nombre del docente");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int j = 0; j < Program.structAssignmentArray.Length; j++)
            {
                if (studentID == Program.structAssignmentArray[j].studentID)
                {
                    Console.WriteLine("\n {0}   {1} \n",getcourseName(Program.structAssignmentArray[j].courseID),getTeacherName(Program.structAssignmentArray[j].teacherID));
                }
            }
        }

        public static string getTeacherName(string teacherID)
        {
            string teacherName = null;
            for (int i = 0; i < Program.structTeachArray.Length; i++)
            {
                if (teacherID == Program.structTeachArray[i].teacherID)
                {
                    teacherName = Program.structTeachArray[i].teacherName;
                }
            }
            return teacherName;
        }

        public static string getcourseName(string courseID)
        {
            string courseName = null;
            for (int i = 0; i < Program.structCourseArray.Length; i++)
            {
                if (courseID == Program.structCourseArray[i].courseID)
                {
                    courseName = Program.structCourseArray[i].courseName;
                }
            }
            return courseName;
        }

        public static void studentDelete()
        {
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Nombre del estudiante \n");
            Console.ForegroundColor = ConsoleColor.White;
            string studentID = Console.ReadLine();
            int condition = 0;
            int studentToDeleteIndex = -1;
            Console.Clear();
            for (int i = 0; i < Program.structStudentArray.Length; i++)
            {
                if (studentID == Program.structStudentArray[i].studentID)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Codigo del estudiante : {0}\n", Program.structStuArray[i].studentID);
                    Console.WriteLine("\n Nombre del estudiante : {0}\n", Program.structStuArray[i].name);
                    Console.WriteLine("\n Apellidos del estudiante : {0}\n", Program.structStuArray[i].lastname);
                    Console.WriteLine("\n Direccion del estudiante : {0}\n", Program.structStuArray[i].address);
                    studentToDeleteIndex = i;
                    condition = 1;
                }
            }
            Console.WriteLine("\n============================================\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;
            if (condition == 1)
            {
                Console.WriteLine("\n Presione la tecla SUPR para eliminar registro.\n");
                if (Console.ReadKey().Key == ConsoleKey.Delete)
                {
                    Program.structStudentArray[stuToDeleteIndex].studentID = null;
                    Program.structStudentArray[stuToDeleteIndex].name = null;
                    Program.structStudentArray[stuToDeleteIndex].lastname = null;
                    Program.structStudentArray[stuToDeleteIndex].address = null;
                    Console.WriteLine("\n Se elimino el registro perteneciente al codigo {0}.\n",studentID);
                }
                else
                {
                    Console.WriteLine("\n No se puede eliminar registro no existente.\n");
                    Console.WriteLine("\n Presione cualquier tecla para volver al menu.\n");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("\n No se pudo encontrar al estudiante con el codigo {0}.\n",studentID);
                
            }
        }
        public static void studentEdit()
        {
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Codigo del estudiante : \n");
            Console.ForegroundColor = ConsoleColor.White;
            string studentID = Console.ReadLine();
            int condition = 0;
            int studentToEditIndex = -1;
            Console.Clear();
            for (int i = 0; i < Program.structStudentArray.Length; i++)
            {
                if (studentID == Program.structStudentArray[i].studentID)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Codigo del estudiante : {0}\n", Program.structStuArray[i].studentID);
                    Console.WriteLine("\n Nombres del estudiante : {0}\n", Program.structStuArray[i].name);
                    Console.WriteLine("\n Apellidos del estudiante : {0}\n", Program.structStuArray[i].lastname);
                    Console.WriteLine("\n Dirección del estudiante : {0}\n", Program.structStuArray[i].address);
                    studentToEditIndex = i;
                    condition = 1;
                }
            }
            Console.WriteLine("\n============================================\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;
            if (condition == 1)
            {
                Console.WriteLine("\n Presiona la tecla F2 para editar el registro.\n");
                if (Console.ReadKey().Key == ConsoleKey.F2)
                {
                    Console.CursorVisible = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Codigo del estudiante : \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Program.structStudentArray[studentToEditIndex].studentID = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Nombres del estudiante : \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Program.structStudentArray[studentToEditIndex].name = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Apellidos del estudiante : \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Program.structStudentArray[studentToEditIndex].lastname = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Direccion del estudiante : \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Program.structStudentArray[studentToEditIndex].address = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n Se edito el registro perteneciente al codigo {0}.\n", studentID);
                }
                else
                {
                    Console.WriteLine("\n No se puede editar registro inexistente.\n");
                    Console.WriteLine("\n Presione cualquier tecla para volver al menu.\n");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("\n No se encontro al estudiante con el codigo {0}.\n", studentID);

            }
        }

    }
}
