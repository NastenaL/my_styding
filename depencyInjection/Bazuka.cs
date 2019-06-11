using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depencyInjection
{
    class Bazuka: IWeapon
    {
        public void Kill()
        {
            Console.WriteLine("This is bazuka");
        }
    }
}
