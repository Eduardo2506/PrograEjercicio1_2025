using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Progra2025
{
    class Program
    {
        static void Main(string[] args)
        {
            Explorer explorer = new Explorer("Indiana Jones", 100, 100);

            while (explorer.IsAlive())
            {
                explorer.Explore();
                explorer.ShowStatus();

                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadLine();
            }

            Console.WriteLine("El juego ha terminado");
            Console.WriteLine(explorer.Health <= 0 ? "Has perdido, tu salud llego a cero" : "Te quedaste sin energia");
        }
    }
}
