using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depencyInjection
{
    class Program
    {
        public static IKernel AppKernel;
        static void Main(string[] args)
        {
            AppKernel = new StandardKernel(new WeaponNinjectModule());
            var warrior = AppKernel.Get<Warrior>();
            warrior.Kill();

            Console.ReadKey();
            /// text
        }
    }
}
