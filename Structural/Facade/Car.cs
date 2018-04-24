using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade
{
    public class Car
    {
        public string Name { get; set; }
        public Car(string name)
        {
            this.Name = name;
        }
    }
}
