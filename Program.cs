using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4._4_Cs
{
    internal class Program
    {
        // Definición de la función "Conducir", que acepta cualquier objeto que implemente la interfaz "IVehiculo"
        public static void Conducir(IVehiculo vehiculo)
        {
            vehiculo.Acelerar();
            vehiculo.Frenar();
        }
        static void Main(string[] args)
        {
            Coche coche = new Coche();
            Moto moto = new Moto();

            Conducir(coche); // Salida: "El coche acelera" y "El coche frena"
            Conducir(moto); // Salida: "La moto acelera" y "La moto frena"

            Console.ReadLine(); // Esperar a que el usuario presione una tecla antes de cerrar la ventana de la consola
        }

    }
}
