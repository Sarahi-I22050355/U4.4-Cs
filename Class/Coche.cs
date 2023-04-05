using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4._4_Cs
{
    internal class Coche : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("El coche acelera");
        }

        public void Frenar()
        {
            Console.WriteLine("El coche frena");
        }
    }
}
