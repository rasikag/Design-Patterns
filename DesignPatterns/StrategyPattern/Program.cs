using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DuckType01 dt01 = new DuckType01();
            dt01.PerformFly();
            dt01.PerformQuack();
            dt01.Display();

            DuckType02 dt04 = new DuckType02();
            dt04.PerformFly();
            dt04.PerformQuack();
            dt04.Display();

            Console.ReadLine();
        }
    }
}
