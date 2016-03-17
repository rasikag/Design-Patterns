using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public QuackBehavior QuackBehavior { get; set; }
        public FlyBehavior FlyBehavior { get; set; }

        public Duck( )
        {
           
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public abstract void Display();
    }
}
