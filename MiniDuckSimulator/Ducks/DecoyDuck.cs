using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            this.SetFlyBehavior(new FlyNoWay());
            this.SetQuackBehavior(new MuteQuackR());
        }

        public override void Display()
        {
            Console.WriteLine("Я DecoyDuck!");
        }
    }
}
