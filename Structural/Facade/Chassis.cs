using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade
{
    class Chassis
    {
        internal bool TiresEquipped(Car car, int day)
        {
            Console.WriteLine("Now checking tires...equipped.");
            return true;
        }
    }
}
