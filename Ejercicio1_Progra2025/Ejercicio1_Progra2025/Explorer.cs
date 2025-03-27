using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Progra2025
{
    internal class Explorer : Character
    {
        public int Treasures;

        public Explorer(string name, int energy, int health) : base(name, energy, health)
        {
            Treasures = 0;
        }

        public override void Explore()
        {
            Console.WriteLine($"{Name} esta explorando la isla...");
            Console.WriteLine("Encuentras un camino dividido, tienes tres opciones:");
            Console.WriteLine("1. Tomar el camino seguro");
            Console.WriteLine("2. Explorar la cueva oscura");
            Console.WriteLine("3. Cruzar el puente en mal estado");
            Console.Write("Elige tu camino (1-3): ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    SafePath();
                    break;
                case "2":
                    DarkCave();
                    break;
                case "3":
                    BrokenBridge();
                    break;
                default:
                    Console.WriteLine("Opción no válida, pierdes energia por la mala eleccion");
                    Energy -= 15;
                    break;
            }
        }
        public override void ShowStatus()
        {
            base.ShowStatus();
            Console.WriteLine($"Tesoros encontrados: {Treasures}");
        }

        private void SafePath()
        {
            Console.WriteLine("Tomaste el camino seguro, encontraste algunos recursos");
            Energy -= 10;
            Treasures++;
            Health += 5;
        }
        private void DarkCave()
        {
            Random random = new Random();
            int result = random.Next(1, 101);

            if (result <= 40)
            {
                Console.WriteLine("Encontraste un gran tesoro en la cueva oscura");
                Treasures += 2;
                Energy -= 20;
            }
            else
            {
                Console.WriteLine("La cueva era muy peligrosa, pierdes vida");
                Health -= 20;
                Energy -= 15;
            }
        }
        private void BrokenBridge()
        {
            Random random = new Random();
            int result = random.Next(1, 101);
            if (result <= 30)
            {
                Console.WriteLine("El puente se rompio un poco pero tuviste suerte al escapar");
                Health -= 10;
                Energy -= 25;
            }
            else
            {
                Console.WriteLine("Cruzaste el puente con cuidado y encontraste un mapa del tesoro");
                Treasures++;
                Energy -= 15;
            }
        }
        public bool IsAlive()
        {
            return Energy > 0 && Health > 0;
        }
    }
}

