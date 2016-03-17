using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class QuackWithSound : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("This Duck can make sound");
        }
    }
}
