using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    public class Student : Person
    {
        public bool isValid;
        public int countMark;
        public int sumMark;
        public int medianMark;

        public static void ValidStudent(List<Student> students)
        {
            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].secondHiEducation == false && students[i].age >= 18 && students[i].finishedSchool == true)
                {
                    students[i].isValid = true;
                }
                else
                {
                    students.RemoveAt(i);
                }
            }
        }

        //public void Rating(List<Students> students)
        //{
        //    List<Students> onBudget = new List<Students>();
        //    List<Students> onContract = new List<Students>();
        //    for (int i = 0; i < students.Count; i++)
        //    {
        //        Console.Write($"ID: {students[i].id}; FULL NAME: {students[i].firstName} {students[i].lastName}; Write student rating: ");
        //        students[i].rating = int.Parse(Console.ReadLine());
        //    }

        //    Students temp;
        //    for (int j = 0; j < students.Count - 1; j++)
        //    {
        //        for (int i = 0; i < students.Count - 1 - j; i++)
        //        {
        //            if (students[i].rating < students[i + 1].rating)
        //            {
        //                temp = students[i];
        //                students[i] = students[i + 1];
        //                students[i + 1] = temp;
        //            }
        //        }
        //    }

        //    float num = students.Count * 0.45f;
        //    int budgetPlaces = (int)Math.Floor(num);
        //    int contractPlaces = students.Count - budgetPlaces;
        //    int count = 1;
        //    Console.WriteLine("Students on budget:");
        //    for (int i = 0; i < budgetPlaces; i++)
        //    {
        //        students[i].id = count++;
        //        Console.WriteLine($"ID: {students[i].id}; FULL NAME: {students[i].firstName} {students[i].lastName};");
        //    }

        //    Console.WriteLine("Students on contract:");
        //    for (int i = budgetPlaces; i < students.Count; i++)
        //    {
        //        students[i].id = count++;
        //        Console.WriteLine($"ID: {students[i].id}; FULL NAME: {students[i].firstName} {students[i].lastName};");
        //    }

        //}
    }
}
