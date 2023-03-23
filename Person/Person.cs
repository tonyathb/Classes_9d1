using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Person
{
    public class Person
    {
       private string name;
        private int age;
        public string Name { get; set; } // property without VALIDATIONs
        public int Age
        {
            get //kak poleto da se VZEME i iznese navan ot klasa
            {
                return age;
            }
            set // pokazva kak poleto da poluchi stojnost
            {
                if (value < 1 || value > 99)// VALUE - tova e stojnost, koyato poluchava poleto otvan
                {
                    Console.WriteLine("Nevalidna stojnost za AGE");
                    age = 0;
                    return;
                }
                else
                {
                    age = value;
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Аз съм {this.Name} и " +
                $"съм на {this.Age} години!");
        }
    }
}
