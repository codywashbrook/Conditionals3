using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals3
{
    internal class Program
    {
        static int health;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals 3");
            Console.WriteLine();

            health = 100;
            Console.WriteLine("Health: " + health);
            if (health > 0)
            {
                Console.WriteLine("Alive");
            }
            else
            {
                Console.WriteLine("Dead");
            }
            TakeDamage(100);
            Console.WriteLine("Health: " + health);
            if (health > 0)
            {
                Console.WriteLine("Alive");
            }
            else
            {
                Console.WriteLine("Dead");
            }
            Console.ReadKey(true);
        }

        static void TakeDamage(int damage)
        {
            Console.WriteLine("Player is about to take " + damage + " damage...");
            health = health - damage;
        }
    }
}
