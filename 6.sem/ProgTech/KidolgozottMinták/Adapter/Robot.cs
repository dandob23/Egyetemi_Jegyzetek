using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Robot
    {
        string ID;
        int memory; //memoria MB-ban megadva
        public Robot(string ID, int memory)
        {
            this.ID = ID;
            this.memory = memory;
        }
        public string GetID() { return ID; }
        public int GetMemory() { return memory; }

    }
}
