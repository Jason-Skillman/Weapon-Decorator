using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_Decorator {

    public class Hammer : Weapon {

        public override int GetDamage() {
            return 2;
        }

        public override string GetName() {
            return "Hammer";
        }

    }

}
