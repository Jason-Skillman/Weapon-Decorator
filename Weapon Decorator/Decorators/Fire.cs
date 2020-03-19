using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_Decorator {

    public class Fire : WeaponDecorator {

        public Fire(Weapon weapon) : base(weapon) { }


        public override int GetDamage() {
            return 2 + Weapon.GetDamage();
        }

        public override string GetName() {
            return "Fire " + Weapon.GetName();
        }

    }

}
