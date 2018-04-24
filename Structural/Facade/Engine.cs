using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade
{
    class Engine
    {
        public bool RadiatorEquipped(Car car, int day)
        {
            Console.WriteLine("Now checking radiator...equipped.");
            return true;
        }
    }
}
