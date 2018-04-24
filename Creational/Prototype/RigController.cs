using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
    public class RigController
    {
        private Dictionary<string, RigPrototype> _rigs = new Dictionary<string, RigPrototype>();

        // Indexer
        public RigPrototype this[string key]
        {
            get { return _rigs[key]; }
            set { _rigs.Add(key, value); }
        }
    }
}
