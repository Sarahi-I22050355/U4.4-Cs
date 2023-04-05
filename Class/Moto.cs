using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4._4_Cs
{
    class Moto : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("La moto acelera");
        }

        public void Frenar()
        {
            Console.WriteLine("La moto frena");
        }
    }
}
