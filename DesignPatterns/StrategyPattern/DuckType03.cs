using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DuckType03 : Duck
    {
        public DuckType03()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Duck type 03");
        }
    }
}
