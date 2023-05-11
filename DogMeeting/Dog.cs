using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogMeeting
{
    public class Dog
    {
        //fields = характеристики на класа Dog
        private string name;
        private string breed;
        private int age;
        static private int counterObjects;

        public static int CountObjects
        {
            get { return counterObjects; }
            //set { counterObjects = value; }
        }


        //method = behaviour
        public void CanBark()
        {
            Console.WriteLine($"{this.Name}--> Bau-bau-bark!");
        }
        public int CanGrow()
        {
            this.Age++;
            Console.WriteLine($"{this.Name} is {this.Age} years old");
            return this.Age;
        }
        //properties = начин да управляваме как се пълнят/празнят полетата
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
                if (value > 0) { age = value; }
                else { age = 0; }
            }
        }

        //constructors
        public Dog(string n, string breed, int age)
        {
            counterObjects++;
            this.Name = n;
            this.Age = age;
            this.Breed = breed;
        }
        public Dog()
        {
            counterObjects++;
            this.Name = "unknown";
            this.Age = 0;
            this.Breed = "unknown";
        }
        public Dog(string name)
        {
            counterObjects++;
            this.Name = name;
            this.Age = 0;
            this.Breed = "unknown";
        }

        public void Print()
        {
            Console.WriteLine($"Ime:{this.Name} Godini:{this.Age} Breed:{this.Breed}");
        }
    }


}
