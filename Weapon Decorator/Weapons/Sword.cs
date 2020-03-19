using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_Decorator {

    public class Sword : Weapon {

        public override int GetDamage() {
            return 1;
        }

        public override string GetName() {
            return "Sword";
        }

    }

}
