using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andon.Entity
{
    internal class Data
    {
        public static MachineState[] machineStates()
        {
            var data = new MachineState[25];
            data[0] = new MachineState("BM1", "M60", "D50", "Y0", "Y26");
            data[1] = new MachineState("BM2", "M61", "D52", "Y1", "Y27");
            data[2] = new MachineState("BM3", "M62", "D54","Y2", "Y30");
            data[3] = new MachineState("BM4", "M63", "D56", "Y3", "Y31");
            data[4] = new MachineState("BM5", "M64", "D58", "Y11", "Y37");
            data[5] = new MachineState("BM6", "M65", "D60", "Y7", "Y35");
            data[6] = new MachineState("BM7", "M66", "D62", "Y10", "Y36");
            data[7] = new MachineState("BM8", "M67", "D64", "Y6", "Y34");
            data[8] = new MachineState("BM9", "M68", "D66", "Y5", "Y33");
            data[9] = new MachineState("BM10", "M69", "D68", "Y4", "Y32");
            data[10] = new MachineState("GRI", "M70", "D70", "Y12", "Y40");
            data[11] = new MachineState("2F1", "M71", "D72", "Y13", "Y41");
            data[12] = new MachineState("2F2", "M72", "D74", "Y14", "Y42");
            data[13] = new MachineState("2F3", "M73", "D76", "Y15", "Y43");
            data[14] = new MachineState("2F4", "M74", "D78", "Y16", "Y44");
            data[15] = new MachineState("2F5", "M75", "D80", "Y17", "Y45");
            data[16] = new MachineState("2F6", "M76", "D82", "Y20", "Y46");
            data[17] = new MachineState("2F7", "M77", "D84", "Y21", "Y47");
            data[18] = new MachineState("2F8", "M78", "D86", "Y22", "Y50");
            data[19] = new MachineState("2F9", "M79", "D88", "Y23", "Y51");
            data[20] = new MachineState("2F10", "M80", "D90", "Y24", "Y52");
            data[21] = new MachineState("2F11", "M81", "D92", "Y62", "Y70");
            data[22] = new MachineState("2F12", "M82", "D94", "Y63", "Y71");
            data[23] = new MachineState("2F13", "M83", "D96", "Y64", "Y72");
            data[24] = new MachineState("KAB", "M84", "D98", "Y25", "Y53");

            return data;

        }
    }
}
