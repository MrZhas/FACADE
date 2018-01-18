using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Sauce sauce = new Sauce();
            Veggies veggies = new Veggies();
            Cutlet cutlet= new Cutlet();
            Bun bun= new Bun();
            Burger burger= new Burger();
            FastfoodCafeFacade ffc = new FastfoodCafeFacade(sauce, veggies, cutlet, bun, burger);
            Cook cook = new Cook();
            cook.CreateBurger(ffc);

            Console.Read();
        }
    }
    
}
