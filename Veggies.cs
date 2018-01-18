using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Veggies
    {
        public void ChopCucumber()
        {
            Console.WriteLine("Нарезка огурца");
        }
        public void ChopOnion()
        {
            Console.WriteLine("Нарезка лука");
        }
        public void ChopTomato()
        {
            Console.WriteLine("Нарезка помидора");
        }
    }
}
