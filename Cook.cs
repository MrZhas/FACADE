using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Cook
    {
        public void CreateBurger(FastfoodCafeFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
