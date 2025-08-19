using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    internal class Program
    { // Пробую на ноуті
        static void Main(string[] args)
        {
            List<Student> students = Data.Students;
            List<Teacher> teachers = Data.Teachers;

            Console.WriteLine("=== Students ===");
            Utils.PrintPeople(students);

            Console.WriteLine("=== Teachers ===");
            Utils.PrintPeople(teachers);

            Console.WriteLine("Do you want to add new students?");
            string str = Console.ReadLine();
            while (true)
            {
                if (str == "y" || str == "Y")
                {
                    List<Student> studentsToAdd = new List<Student>();

                    Console.WriteLine("How many students do you want to add?");
                    int count = int.Parse(Console.ReadLine());

                    for (int i = 0; i < count; i++)
                    {
                        Student s = new Student();

                        s.id = Guid.NewGuid();
                        Console.Write("Enter firstname: ");
                        s.firstName = Console.ReadLine();

                        Console.Write("Enter lastname: ");
                        s.lastName = Console.ReadLine();

                        Console.Write("Enter age: ");
                        s.age = int.Parse(Console.ReadLine());

                        Console.Write("Have second higher education? (y/n): ");
                        str = Console.ReadLine();
                        while (true)
                        {
                            if (str == "y" || str == "Y")
                            {
                                s.secondHiEducation = true;
                                break;
                            }
                            else if (str == "n" || str == "N")
                            {
                                s.secondHiEducation = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid symbol, try again)");
                                str = Console.ReadLine();
                            }
                        }

                        Console.Write("Have finished school? (y/n): ");
                        str = Console.ReadLine();
                        while (true)
                        {
                            if (str == "y" || str == "Y")
                            {
                                s.finishedSchool = true;
                                break;
                            }
                            else if (str == "n" || str == "N")
                            {
                                s.finishedSchool = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid symbol, try again)");
                                str = Console.ReadLine();
                            }
                        }

                        Console.Write("Enter his/her group: ");
                        s.group = Console.ReadLine();

                        studentsToAdd.Add(s);
                    }
                }
                else if (str == "n" || str == "N")
                {
                    Console.WriteLine("Okey, moving to the next point");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid symbol, try again)");
                    str = Console.ReadLine();
                }
            }

            //List<Student> group122 = Utils.GetGroups<Student>(studentsList, true);
            //List<Student> group123 = Utils.GetGroups<Student>(studentsList, false);
            //List<Teacher> group122T = Utils.GetGroups<Teacher>(teachersList, true);
            //List<Teacher> group123T = Utils.GetGroups<Teacher>(teachersList, false);

            //group122 = students.ValidStudent(group122);
            //group123 = students.ValidStudent(group123);

            //Console.WriteLine("=== Teachers 122 ===");
            //Utils.PrintPeople(group122T);

            //Console.WriteLine("=== Valid Students 122 ===");
            //Utils.PrintPeople(group122);

            //Console.WriteLine("=== Teachers 123 ===");
            //Utils.PrintPeople(group123T);

            //Console.WriteLine("=== Valid Students 123 ===");
            //Utils.PrintPeople(group123);

            //Console.WriteLine("Do you want to get information about any of teachers?");
            //str = Console.ReadLine();
            //bool isAddInformUsed = false;
            //while (isAddInformUsed == false)
            //{
            //    if (str == "y" || str == "Y")
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine("Enter group num");
            //            str = Console.ReadLine();

            //            int ID = -1;
            //            if (str == "122" || str == "123")
            //            {
            //                while (true)
            //                {
            //                    try
            //                    {
            //                        Console.WriteLine("Enter teacher`s ID");
            //                        ID = Convert.ToInt32(Console.ReadLine());
            //                        break;
            //                    }
            //                    catch (FormatException)
            //                    {
            //                        Console.WriteLine("Enter the right num!");
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Write corect number");
            //            }

            //            if (str == "122")
            //            {
            //                for (int i = 0; i < group122T.Count; i++)
            //                {
            //                    if (group122T[i].id == ID)
            //                    {
            //                        Utils.AdditionalInformation(group122T, group122, ID);
            //                        isAddInformUsed = true;
            //                        break;
            //                    }
            //                }
            //            }
            //            else if (str == "123")
            //            {
            //                for (int i = 0; i < group123T.Count; i++)
            //                {
            //                    if (group123T[i].id == ID)
            //                    {
            //                        Utils.AdditionalInformation(group123T, group123, ID);
            //                        isAddInformUsed = true;
            //                        break;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    else if (str == "n" || str == "N")
            //    {
            //        Console.WriteLine("Okey, moving to the next point :)");
            //        isAddInformUsed = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong character, try again :(");
            //        str = Console.ReadLine();
            //    }
            //}

            //Console.WriteLine("Do you want set marks to students? :)");
            //str = Console.ReadLine();
            //if (str == "y" || str == "Y")
            //{
            //    Console.WriteLine("Enter group num");
            //    str = Console.ReadLine();

            //    if (str == "122")
            //    {
            //        Teacher.SetMark(group122);
            //    }
            //    else if (str == "123")
            //    {
            //        Teacher.SetMark(group123);
            //    }
            //}
            //else if (str == "n" || str == "N")
            //{
            //    Console.WriteLine("Okey, maybe we will do it next time :)");
            //    isAddInformUsed = true;
            //}
            //Console.ReadLine();
        }
    }
}
