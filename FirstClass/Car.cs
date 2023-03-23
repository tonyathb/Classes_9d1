using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Car
    {
        public string brand;
        public int power;
        public string color;
        public void CanMaove()
        {
            Console.WriteLine($"{brand} >> Brum-brum-brum!");
        }

    }
}
