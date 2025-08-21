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
using static Praktika.Data;

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
                bool isAdded = false;
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
                        str = Console.ReadLine();
                        switch (str)
                        {
                            case "122":
                                s.group = Groups.Group122;
                                isAdded = true;
                                break;
                            case "123":
                                s.group = Groups.Group123;
                                isAdded = true;
                                break;
                            default:
                                Console.WriteLine("Invalid group, setting default Group122");
                                s.group = Groups.Group122;
                                isAdded = true;
                                break;
                        }

                        studentsToAdd.Add(s);
                    }
                    AddStudents(studentsToAdd);
                    break;
                }
                else if (str == "n" || str == "N")
                {
                    Console.WriteLine("Okey, moving to the next point");
                    break;
                }
                else if (isAdded == false)
                {
                    Console.WriteLine("Invalid symbol, try again)");
                    str = Console.ReadLine();
                }
            }

            List<Student> group122 = Utils.GetGroups<Student>(students, Data.Groups.Group122);
            List<Student> group123 = Utils.GetGroups<Student>(students, Data.Groups.Group123);
            List<Teacher> group122T = Utils.GetGroups<Teacher>(teachers, Data.Groups.Group122T);
            List<Teacher> group123T = Utils.GetGroups<Teacher>(teachers, Data.Groups.Group123T);

            Student.ValidStudent(group122);
            Student.ValidStudent(group123);


            Console.WriteLine("=== Teachers 122 ===");
            Utils.PrintPeople(group122T);

            Console.WriteLine("=== Valid Students 122 ===");
            Utils.PrintPeople(group122);

            Console.WriteLine("=== Teachers 123 ===");
            Utils.PrintPeople(group123T);

            Console.WriteLine("=== Valid Students 123 ===");
            Utils.PrintPeople(group123);

            Console.WriteLine("Do you want to get information about students or teachers?");
            str = Console.ReadLine();
            bool isAddInformUsed = false;
            while (isAddInformUsed == false)
            {
                if (str == "y" || str == "Y")
                {
                    string firstName, lastName;
                    while (true)
                    {
                        Console.WriteLine("Enter first name");
                        firstName = Console.ReadLine();

                        Console.WriteLine("Enter last name");
                        lastName = Console.ReadLine();

                        Utils.AdditionalInformation(teachers, students, firstName, lastName);
                        Console.WriteLine("You want to do it again?");
                        str = Console.ReadLine();
                        if (str != "y" && str != "Y")
                        {
                            break;
                        }
                    }
                    break;
                }
                else if (str == "n" || str == "N")
                {
                    Console.WriteLine("Okey, moving to the next point :)");
                    isAddInformUsed = true;
                }
                else
                {
                    Console.WriteLine("Wrong character, try again :(");
                    str = Console.ReadLine();
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
                    Teacher.SetMark(group122);
                }
                else if (str == "123")
                {
                    Teacher.SetMark(group123);
                }
            }
            else if (str == "n" || str == "N")
            {
                Console.WriteLine("Okey, maybe we will do it next time :)");
                isAddInformUsed = true;
            }
            Console.ReadLine();
        }
    }
}
