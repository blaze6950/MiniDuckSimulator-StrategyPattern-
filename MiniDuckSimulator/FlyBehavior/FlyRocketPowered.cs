using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Я летаю на ракете!");
        }
    }
}
