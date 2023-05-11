using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace MyPets
{
    public class Cat
    {
        private string name;
        private string breed;
        private int age;

        public string Name { get; set; }

        public string Breed { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set 
            { 
                if (value < 15 && value > 0)
                {
                      age= value;
                }
                else
                {
                    Console.WriteLine("greshni godini");
                    age = 0;
                }
            }
        }
        public  void Print()
        {
            Console.WriteLine($"Ime:{this.Name} Godini:{this.Age} Breed:{this.Breed}");
        }
        public Cat()
        {
            this.Age = 1;
            this.Name = "Unknow";
            this.Breed = "Unknow";
        }
        public Cat(string name,string breed,int age)
        {
            this.Age = age;
            this.Name = name;
            this.Breed = breed;
        }
    }
}
