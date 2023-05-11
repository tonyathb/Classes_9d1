using DogMeeting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOfDogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pack packSopot=new Pack();
            packSopot.Name = "Sopot-stadiona";
            Console.WriteLine("Vavedi 4lenove na glutnicata: .... do END");
            string input = Console.ReadLine();
            Dog currentDog = new Dog();
            while(input != "END")
            {
                Console.Write("Poroda");
                currentDog.Breed = Console.ReadLine();
                Console.Write("Name");
                currentDog.Name = Console.ReadLine();
                Console.Write("Age");
                currentDog.Age = int.Parse(Console.ReadLine());
                packSopot.Members.Add(currentDog);
                input = Console.ReadLine();
            }
        }
    }
}
