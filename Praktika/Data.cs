using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    public class Data
    {
        public static void HardCodeStudents(List<Students> students)
        {
            students.Add(new Students { id = 1, firstName = "Ivan", lastName = "Kovalchuk", age = 18, secondHiEducation = false, finishedSchool = true, group = "123" });
            students.Add(new Students { id = 2, firstName = "Olena", lastName = "Syvorenko", age = 25, secondHiEducation = true, finishedSchool = true, group = "122" });
            students.Add(new Students { id = 3, firstName = "Artem", lastName = "Bondar", age = 17, secondHiEducation = false, finishedSchool = true, group = "123" });
            students.Add(new Students { id = 4, firstName = "Maria", lastName = "Lytvynenko", age = 35, secondHiEducation = false, finishedSchool = false, group = "122" });
            students.Add(new Students { id = 5, firstName = "Vladyslav", lastName = "Petrenko", age = 20, secondHiEducation = false, finishedSchool = true, group = "123" });
            students.Add(new Students { id = 6, firstName = "Anastasiia", lastName = "Moroz", age = 16, secondHiEducation = false, finishedSchool = false, group = "122" });
            students.Add(new Students { id = 7, firstName = "Denys", lastName = "Shevchenko", age = 19, secondHiEducation = false, finishedSchool = true, group = "123" });
            students.Add(new Students { id = 8, firstName = "Kateryna", lastName = "Ivanova", age = 22, secondHiEducation = false, finishedSchool = true, group = "122" });
            students.Add(new Students { id = 9, firstName = "Dmytro", lastName = "Honchar", age = 45, secondHiEducation = false, finishedSchool = true, group = "123" });
            students.Add(new Students { id = 10, firstName = "Sofiia", lastName = "Romanenko", age = 29, secondHiEducation = false, finishedSchool = true, group = "122" });
        }

        public static void HardCodeTeachers(List<Teachers> teachers)
        {
            teachers.Add(new Teachers { id = 1, firstName = "Olena", lastName = "Kravchenko", age = 45, secondHiEducation = true, finishedSchool = true, group = "123" });
            teachers.Add(new Teachers { id = 2, firstName = "Petro", lastName = "Shevchenko", age = 39, secondHiEducation = true, finishedSchool = true, group = "122" });
            teachers.Add(new Teachers { id = 3, firstName = "Iryna", lastName = "Koval", age = 50, secondHiEducation = true, finishedSchool = true, group = "123" });
            teachers.Add(new Teachers { id = 4, firstName = "Serhii", lastName = "Bondar", age = 33, secondHiEducation = true, finishedSchool = true, group = "122" });
            teachers.Add(new Teachers { id = 5, firstName = "Tetiana", lastName = "Moroz", age = 41, secondHiEducation = true, finishedSchool = true, group = "123" });
        }

        public static void AddStudents(List<Students> student, int count)
        {
            for (int i = student.Count; i < count; i++)
            {
                string str;
                student.Add(new Students { });
                Console.WriteLine("Enter information about student:");
                student[i].id = i + 1;
                Console.WriteLine($"Students id is: {student[i].id} ");
                Console.Write("Enter firstname: ");
                student[i].firstName = Console.ReadLine();
                Console.Write("Enter lastname: ");
                student[i].lastName = Console.ReadLine();
                Console.Write("Enter age: ");
                student[i].age = int.Parse(Console.ReadLine());
                Console.Write("Have second higher education? Write y or n: ");
                str = Console.ReadLine();
                while (true)
                {
                    if (str == "y" || str == "Y")
                    {
                        student[i].secondHiEducation = true;
                        break;
                    }
                    else if (str == "n" || str == "N")
                    {
                        student[i].secondHiEducation = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid symbol, try again)");
                    }
                }

                Console.Write("Have finished school? Write y or n: ");
                str = Console.ReadLine();
                while (true)
                {
                    if (str == "y" || str == "Y")
                    {
                        student[i].finishedSchool = true;
                        break;
                    }
                    else if (str == "n" || str == "N")
                    {
                        student[i].finishedSchool = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid symbol, try again)");
                    }
                }
                Console.WriteLine("Enter his/her group");
                str = Console.ReadLine();
                student[i].group = str;
            }
        }
    }
}
