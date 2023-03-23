using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car carOpel = new Car();
            Car carBMW = new Car();

            carOpel.brand = "OPEL";
            carBMW.brand = "bmw";
            carOpel.CanMaove();
            carBMW.CanMaove();
        }
    }
}
