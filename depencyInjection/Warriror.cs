using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depencyInjection
{
    class Warrior
    {
        readonly IWeapon Weapon;
        public Warrior(IWeapon Weapon)
        {
            this.Weapon = Weapon;
        }

        public void Kill()
        {
            Weapon.Kill();
        }
    }
}
