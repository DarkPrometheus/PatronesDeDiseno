using PatronesDeDiseño.ClasesVarias;
using PatronesDeDiseño.Strategy.Fly;
using PatronesDeDiseño.Strategy.QuackFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        
        public override void Display()
        {
            Please.WriteWithTop("I'm a real Mallard duck");
        }
    }
}
