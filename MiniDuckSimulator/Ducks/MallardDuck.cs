using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.SetFlyBehavior(new FlyWithWings());
            this.SetQuackBehavior(new QuackR());
        }

        public override void Display()
        {
            Console.WriteLine("Я Mallard Duck!");
        }
    }
}
