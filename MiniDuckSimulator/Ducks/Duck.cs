using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    abstract class Duck
    {
        private IFlyBehavior flyBehavior;
        private IQuackBehavior quackBehavior;
        public Duck()
        {
        }
        public void Swim()
        {
            Console.WriteLine("Я плаваю");
        }
        public virtual void Display()
        {
            Console.WriteLine("Я утка!");
        }
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }
        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
