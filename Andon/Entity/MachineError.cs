using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andon.Entity
{
    internal class MachineError
    {
        public string Name { get; set; }
        public int Valuemaint { get; set; }
        public int Valuepro { get; set; }
        public MachineError(string name, int valuemaint, int valuepro)
        {
            Name = name;
            Valuemaint = valuemaint;
            Valuepro = valuepro;
        }
        public MachineError()
        {

        }
    }
}
