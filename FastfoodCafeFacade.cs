using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class FastfoodCafeFacade
    {
        Sauce sauce;
        Veggies veggies;
        Cutlet cutlet;
        Bun bun;
        Burger burger;

      



        public FastfoodCafeFacade(Sauce sa, Veggies ve, Cutlet cu, Bun bun, Burger bur)
        {
            this.sauce = sa;
            this.veggies = ve;
            this.cutlet = cu;
            this.bun = bun;
            this.burger = bur;
        }
        public void Start()
        {
            sauce.Mix();
            veggies.ChopCucumber();
            veggies.ChopOnion();
            veggies.ChopTomato();
            cutlet.Barbecue();
            bun.Slit();
            bun.Fry();
        }
        public void Stop()
        {
            burger.SqueezeBun();
        }

    }
}
