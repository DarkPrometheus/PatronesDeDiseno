using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.ClasesVarias;

namespace PatronesDeDiseño.Strategy.QuackFolder
{
    public class MuteQuack : IQuackBehavior
    {
        public void DoQuack()
        {
            Please.WriteWithTop("<< Silence >>");
        }
    }
}
