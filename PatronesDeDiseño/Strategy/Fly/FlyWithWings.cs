using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.ClasesVarias;

namespace PatronesDeDiseño.Strategy.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Please.WriteWithTop("I'm flying!!");
        }
    }
}
