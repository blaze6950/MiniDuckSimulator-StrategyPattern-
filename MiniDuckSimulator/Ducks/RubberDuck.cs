using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.SetFlyBehavior(new FlyNoWay());
            this.SetQuackBehavior(new SqueakR());
        }

        public override void Display()
        {
            Console.WriteLine("Я RubberDuck!");
        }
    }
}
