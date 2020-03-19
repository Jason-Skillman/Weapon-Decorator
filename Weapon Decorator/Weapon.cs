using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_Decorator {

    public abstract class Weapon {

        private String name;
        private int damage;


        public abstract String GetName();
        public abstract int GetDamage();

    }

}
