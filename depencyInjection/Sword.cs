﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depencyInjection
{
    class Sword: IWeapon
    {
        public void Kill()
        {
            Console.WriteLine("This is sword");
        }
    }
}
