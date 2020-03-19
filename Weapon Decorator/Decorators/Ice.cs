using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_Decorator {

    public class Ice : WeaponDecorator {

        public Ice(Weapon weapon) : base(weapon) { }


        public override int GetDamage() {
            return 3 + Weapon.GetDamage();
        }

        public override string GetName() {
            return "Ice " + Weapon.GetName();
        }

    }

}
