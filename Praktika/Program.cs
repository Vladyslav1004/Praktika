using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> studentsList = new List<Students>();
            List<Teachers> teachersList = new List<Teachers>();

            Students students = new Students();
            Teachers teachers = new Teachers();

            Data.HardCodeStudents(studentsList);
            Data.HardCodeTeachers(teachersList);

            Console.WriteLine("=== Students ===");
            Utils.PrintPeople(studentsList);

            Console.WriteLine("=== Teachers ===");
            Utils.PrintPeople(teachersList);

            Console.WriteLine("Do you want to add new students?");
            string str = Console.ReadLine();
            while (true)
            {
                if (str == "y" || str == "Y")
                {
                    Console.WriteLine("How many students you want to add ?");
                    int count = Convert.ToInt32(Console.ReadLine());
                    Data.AddStudents(studentsList, count);
                    Console.WriteLine("=== Students ===");
                    Utils.PrintPeople(studentsList);
                    break;
                }
                else if (str == "n" || str == "N")
                {
                    Console.WriteLine("Okey, moving to the next point");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid symbol, try again)");
                }
            }

            List<Students> group122 = Utils.Grouping<Students>(studentsList, true);
            List<Students> group123 = Utils.Grouping<Students>(studentsList, false);
            List<Teachers> group122T = Utils.Grouping<Teachers>(teachersList, true);
            List<Teachers> group123T = Utils.Grouping<Teachers>(teachersList, false);

            group122 = students.ValidStudent(group122);
            group123 = students.ValidStudent(group123);

            Console.WriteLine("=== Teachers 122 ===");
            Utils.PrintPeople(group122T);

            Console.WriteLine("=== Valid Students 122 ===");
            Utils.PrintPeople(group122);

            Console.WriteLine("=== Teachers 123 ===");
            Utils.PrintPeople(group123T);

            Console.WriteLine("=== Valid Students 123 ===");
            Utils.PrintPeople(group123);

            Console.WriteLine("Do you want to get information about any of teachers?");
            str = Console.ReadLine();
            if (str == "y" || str == "Y")
            {
                Console.WriteLine("Enter group num");
                str = Console.ReadLine();

                if (str == "122")
                {
                    Console.WriteLine("Enter teacher`s ID");
                    int ID = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < group122T.Count; i++)
                    {
                        
                        if (group122T[i].id == ID)
                        {
                           Utils.AInformation(group122T, group122, ID);
                        }
                    }
                }
                else if (str == "123")
                {
                    Console.WriteLine("Enter teacher`s ID");
                    int ID = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < group123T.Count; i++)
                    {
                        if (group123T[i].id == ID)
                        {
                            Utils.AInformation(group123T, group123, ID);
                        }
                    }
                }            
            }

            Console.WriteLine("Do you want set marks to students? :)");
            str = Console.ReadLine();
            if (str == "y" || str == "Y")
            {
                Console.WriteLine("Enter group num");
                str = Console.ReadLine();

                if (str == "122")
                {

                    Teachers.SetMark(group122);

                }
                else if (str == "123")
                {
                    Teachers.SetMark(group123);
                }
            }
            Console.ReadLine();
        }
    }
}
