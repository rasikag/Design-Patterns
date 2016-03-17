using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DuckType02 : Duck
    {
        public DuckType02()
        {
            QuackBehavior = new Squeak();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("Duck type 02");
        }
    }
}
