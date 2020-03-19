using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_Decorator {
    class Driver {
        static void Main(string[] args) {

            Weapon weaponSword = new Sword();
            weaponSword = new Fire(weaponSword);
            weaponSword = new Ice(weaponSword);
            weaponSword = new Lighting(weaponSword);

            Weapon weaponBow = new Bow();

            Weapon weaponHammer = new Hammer();
            weaponHammer = new Lighting(weaponHammer);



            Console.WriteLine("Weapon 1: " + weaponSword.GetName());
            Console.WriteLine("Damage: " + weaponSword.GetDamage());

            Console.WriteLine("Weapon 2: " + weaponBow.GetName());
            Console.WriteLine("Damage: " + weaponBow.GetDamage());

            Console.WriteLine("Weapon 3: " + weaponHammer.GetName());
            Console.WriteLine("Damage: " + weaponHammer.GetDamage());

            Console.ReadLine();
        }
    }
}
