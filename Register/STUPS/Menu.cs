using System;
using System.Collections.Generic;
using System.Text;

namespace STUPS
{
    class Menu
    {
        public Menu()
        {
            //Constructor of "Menu" Class
        }
        public static void CreatMenu()
        {
            Console.Title = "Registro de Alumnos - Console C#";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 1 . Ingresar Nuevo Registro. \n");
            Console.WriteLine("\n 2 . Editar Registro.  \n");
            Console.WriteLine("\n 3 . Borrar Registro. \n");
            Console.WriteLine("\n 4 . Asignacion de Clase (solo para estudiantes). \n");
            Console.WriteLine("\n 5 . Ver Registros (solo para estudiantes). \n");
            Console.WriteLine("\n 6 . Salir. \n");
            Console.WriteLine("\n\n Por favor, digite un numero entre el 1 al 6 \n");
            Console.CursorVisible = false;
            string selItem = Console.ReadKey().KeyChar.ToString();
            if (selItem == "1" || selItem == "2" || selItem == "3" || selItem == "4" || selItem == "5" || selItem == "6")
            {
                Console.Clear();
                switch (selItem)
                {
                    case "1": // Ingresar nuevo registro
                        CreatSubMenu();
                        break;
                    case "2": // Editar Registro
                        Register.studentEdit();
                        CreatMenu();
                        break;
                    case "3": // Borrar Regitro
                        Register.studentDelete();
                        CreatMenu();
                        break;
                    case "4": // Asignacion de Clase
                        Program.structAssignmentArray = Register.AssignmentData(Program.structAssignmentArray);
                        CreatMenu();
                        break;
                    case "5": // Ver Registro  - Estudiantes
                        Register.showInformation();
                        Console.ReadLine();
                        CreatMenu();
                        break;
                    case "6": // Salir
                        Console.WriteLine("Gracias por usar la aplicacion \n -  Williams Castañeda");
                         break;
                }
            }
            else
            {
                Console.Beep();
                CreatMenu();
            }
        }
        public static void CreatSubMenu() // Ingresar Nuevo Registro
        {
            Console.Title = "Nuevo Registro";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 1 . Ingresar datos de estudiante \n");
            Console.WriteLine("\n 2 . Ingresar datos de docente.  \n");
            Console.WriteLine("\n 3 . Ingresar nombre de la clase. \n");
            Console.WriteLine("\n 4 . Volver al menu principal. \n");
            Console.WriteLine("\n\n Por favor, digite un numero entre el 1 y el 4 \n");
            Console.CursorVisible = false;
            string selSubItem = Console.ReadKey().KeyChar.ToString();
            if (selSubItem == "1" || selSubItem == "2" || selSubItem == "3" || selSubItem == "4")
            {
                Console.Clear();
                switch (selSubItem)
                {
                    case "1": // Ingresar datos de estudiante
                        Program.structStudentArray = Register.studentData(Program.structStudentArray);
                        CreatSubMenu();
                        break;
                    case "2": // Ingresar datos de docente
                        Program.structTeachArray = Register.teacherData(Program.structTeachArray);
                        CreatSubMenu();
                        break;
                    case "3": // Ingresar nombre de la clase
                        Program.structCourseArray = Register.courseData(Program.structCourseArray);
                        CreatSubMenu();
                        break;
                    case "4": // Volver al menu principal
                        CreatMenu();
                        break;
                }
            }
            else
            {
                Console.Beep();
                CreatSubMenu();
            }
        }
    }
}
