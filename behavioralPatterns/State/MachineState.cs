using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    abstract class MachineState
    {
        public abstract void Start(Machine machine);
        public abstract void Process(Machine machine,string data);
        public abstract void End(Machine machine);
    }
}
