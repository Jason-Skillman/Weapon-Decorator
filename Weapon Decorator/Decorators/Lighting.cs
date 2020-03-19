using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_Decorator {

    public class Lighting : WeaponDecorator {

        public Lighting(Weapon weapon) : base(weapon) { }


        public override int GetDamage() {
            return 4 + Weapon.GetDamage();
        }

        public override string GetName() {
            return "Lighting " + Weapon.GetName();
        }

    }

}
