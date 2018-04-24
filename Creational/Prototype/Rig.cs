using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
    public class Rig : RigPrototype
    {
        private CpuType _cpuType;
        private int _ramSlots;
        private string _mainboardBrand;
        public override RigPrototype Clone()
        {
            Console.WriteLine("Your rig has been cloned to: {0,3}, {1,3}, {2,3}", _cpuType,_ramSlots,_mainboardBrand);
            return this.MemberwiseClone() as RigPrototype;    
        }
        public Rig(CpuType cpuType, int ramSlots, string mainboardBrand)
        {
            this._cpuType = cpuType;
            this._ramSlots = ramSlots;
            this._mainboardBrand = mainboardBrand;
        }
    }
    
          public enum CpuType
        {
            INTEL,
            AMD
        }
}
