using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade
{
    class Extra
    {
        internal bool MirrorsEquipped(Car car, int day)
        {
            Console.WriteLine("Now checking mirrors...equipped.");
            return true;
        }
    }
}
