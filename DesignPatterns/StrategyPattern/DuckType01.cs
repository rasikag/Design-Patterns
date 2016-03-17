using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{

    public class DuckType01 : Duck
    {
        // concrete implimentation 

        public DuckType01()
        {
            QuackBehavior = new QuackWithSound();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("Duck type 01");
        }
    }
}
