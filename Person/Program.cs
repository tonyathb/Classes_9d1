using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student1 = new Person();
            Person student2 = new Person();
            Person teacher = new Person();
            List<Person> group = new List<Person>(); //spisak ot Person-i 
            Console.Write("Vavedi count of the group: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Person currentStudent = new Person();
                Console.Write($"Enter the name of student{i}: ");
                currentStudent.Name = Console.ReadLine();
                Console.Write($"Enter the age of student{i}: ");
                currentStudent.Age = int.Parse(Console.ReadLine());
                group.Add( currentStudent );
            }

            teacher.Age = 52;
            teacher.Name = "Tonya Belezireva";

            student1.Name = "class 9d1";
            student1.Age = 15;

            //input from Console
            //Console.Write("Enter the name of student: ");
            //student2.Name = Console.ReadLine();
            //Console.Write("Enter the age of student: ");
            //student2.Age=int.Parse(Console.ReadLine());


            Console.WriteLine(student1.Name + ": " + student1.Age + " years");
            teacher.IntroduceYourself();
            Console.Write("The new student is: ");
            student2.IntroduceYourself();

            foreach (var item in group)
            {
                Console.Write("->.");
                item.IntroduceYourself();
            }
        }
    }
}
