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

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        // following methods will change the behavior in runtime

        public void SetFlyBehavior(FlyBehavior F)
        {
            FlyBehavior = F;
        }

        public void SetQueakBehavior(QuackBehavior Q)
        {
            QuackBehavior = Q;
        }

        public abstract void Display();
    }
}
