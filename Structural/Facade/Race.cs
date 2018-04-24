using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade
{
    // this will be our facade
    public class Race
    {
        private Engine _engine = new Engine();
        private Chassis _chassis = new Chassis();
        private Extra _extra = new Extra();

        public bool IsReady(Car car, int day)
        {
            Console.WriteLine("{0} on Day {1} enters the race.\n", car.Name, day);
            bool ready = true;

            // check engine
            if(!_engine.RadiatorEquipped(car, day))
            {
                ready = false;
            }

            // check chassis
            if(!_chassis.TiresEquipped(car, day))
            {
                ready = false;
            }

            // check accesories;
            if(!_extra.MirrorsEquipped(car, day))
            {
                ready = false;
            }

            Console.WriteLine("\n{0} is {1} ready for the race.",car.Name, ready ? "now" : "not" );
            return ready;
        }
    }
}
