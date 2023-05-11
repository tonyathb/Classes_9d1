using DogMeeting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPets
{
    public class MyPerson
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}
        public List<Dog> PetDogs { get; set; }
        public List<Cat> PetCats { get; set; } =new List<Cat>();
        public MyPerson(string name,int age)
        {
            this.Name = name;
			this.Age = age;
        }

        
        public void PrintMe()
        {
            Console.WriteLine($"az sum {this.Name} i sum na {this.Age}");
            Console.WriteLine( "my dogs are: ");
            foreach (Dog item in PetDogs)
            {
                item.Print();
            }
            Console.WriteLine("My Pet CatS are: ");
            foreach (Cat item in PetCats)
            {
                item.Print();
            }
        }
        
    }
}
