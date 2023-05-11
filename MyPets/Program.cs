using DogMeeting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Колко човека ще въвеждате? ");
            int n = int.Parse(Console.ReadLine());

            Cat cat1= new Cat();
            Cat cat2= new Cat("Pussy","persiiska",3);

            Dog dog1 = new Dog();
            Dog dog2 = new Dog("Rex","lovno",12);
            Dog dog3 = new Dog("Titka","ovcharka",3);
            List<Cat> cats = new List<Cat>();
            cats.Add(cat1);
            cats.Add(cat2);

            List<Dog> dogs = new List<Dog>();
            dogs.Add(dog3);
            dogs.Add(dog1);
            dogs.Add(dog2);

            MyPerson chovek1 = new MyPerson("boqn",10);
            chovek1.PetDogs = dogs;//.Add(dog2);
            chovek1.PetCats.Add(cat1);
            chovek1.PetCats.Add(cat2);
            chovek1.PrintMe();

            Console.WriteLine("-------------\n Oldest pets are:");
            int maxDogsAge = chovek1.PetDogs.Max(x => x.Age);
            var var1=chovek1.PetDogs.Where(x=>x.Age==maxDogsAge).ToList();
            var var2=chovek1.PetDogs.First(x=>x.Age==maxDogsAge);
            int maxCatsAge = chovek1.PetCats.Select(x => x.Age).Max();
            var var3=chovek1.PetCats.OrderBy(x=>x.Age).Take(1);
            Console.WriteLine($"Dog {maxDogsAge} => {var2}"); var2.Print();
            Console.WriteLine($"Cat {maxCatsAge} => {var3}"); var3.First().Print();
        }
    }
}
