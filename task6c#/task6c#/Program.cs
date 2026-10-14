using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task6c_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("===== ADVENTURE GAME =====");

            Warrior warrior = new Warrior("lujain", 80);
            Wizard wizard = new Wizard("sara", 70);

            List<GameCharacter> characters = new List<GameCharacter>()
        {
            warrior,
            wizard
        };

            foreach (GameCharacter character in characters)
            {
                Console.WriteLine($"\n{character.Name} enters the game!");

                character.UseSpecialAbility();

                character.TakeDamage(10);
                character.DisplayHealth();
            }

            Console.WriteLine();

            warrior.Heal();
            warrior.Heal(15);

            Console.WriteLine();

            HealthPotion potion = new HealthPotion("Health Potion");
            potion.Collect();

            potion.Use(wizard, "15");
            potion.Use(wizard, "abc");
        }
    }

}
