using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.ClasesVarias;

namespace PatronesDeDiseño.Strategy.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Please.WriteWithTop("I can't fly");
        }
    }
}
