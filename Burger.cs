using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Burger
    {
        public void SpreadSauce()
        {
            Console.WriteLine("Обмазать булочку соусом");
        }

        public void PutCutlet()
        {
            Console.WriteLine("Положить котлету на булочку с соусом");
        }

        public void PutVeggies()
        {
            Console.WriteLine("Разложить овощи поверх котлеты");
        }

        public void SqueezeBun()
        {
            Console.WriteLine("Прижать половиной булочки все ингредиенты");
        }
    }
}
