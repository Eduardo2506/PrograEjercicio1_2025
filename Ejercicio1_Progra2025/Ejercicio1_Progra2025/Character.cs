using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Progra2025
{
    internal class Character
    {
        public string Name;
        public int Energy;
        public int Health;

        public Character(string name, int energy, int health)
        {
            Name = name;
            Energy = energy;
            Health = health;
        }

        public virtual void Explore()
        {
            Console.WriteLine($"{Name} está explorando");
            Energy -= 5;
        }
        public virtual void ShowStatus()
        {
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Energía: {Energy}");
            Console.WriteLine($"Salud: {Health}");
        }
    }
}
