using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_Decorator {

    public abstract class WeaponDecorator : Weapon {

        protected Weapon Weapon {
            get; private set;
        }


        public WeaponDecorator(Weapon weapon) {
            Weapon = weapon;
        }
        
    }

}
