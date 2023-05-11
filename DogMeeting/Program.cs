using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogMeeting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog koli = new Dog();
            Dog pin4er4e = new Dog();
            Dog karaman = new Dog();
            Console.WriteLine("Zapochva dog meeting:");
            koli.Name = "Lasi";
            koli.Age = 1;
            koli.Breed = "Collie";

            pin4er4e.Name = "Johny";
            pin4er4e.Age = 2;
            pin4er4e.Breed = "Pincher";

            karaman.Name = "Rex";
            karaman.Age = 3;
            karaman.Breed = "Ovcharka";

            koli.CanBark();
            karaman.CanBark();
            pin4er4e.CanBark();
            pin4er4e.CanBark();
            Dog pumi = new Dog("Cezar", "ul", 1);
            pumi.CanBark();
            pumi.CanGrow();

            Console.WriteLine(Dog.CountObjects);
        }
    }
}
