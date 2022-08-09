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
            var data = new MachineState[30];
            data[0] = new MachineState("BM1", "M60", "D50", "Y0", "Y26","D128","D0");
            data[1] = new MachineState("BM2", "M61", "D52", "Y1", "Y27","D130", "D2");
            data[2] = new MachineState("BM3", "M62", "D54","Y2", "Y30","D132", "D4");
            data[3] = new MachineState("BM4", "M63", "D56", "Y3", "Y31","D134", "D6");
            data[4] = new MachineState("BM5", "M64", "D58", "Y11", "Y37","D146", "D8");
            data[5] = new MachineState("BM6", "M65", "D60", "Y7", "Y35","D142", "D10");
            data[6] = new MachineState("BM7", "M66", "D62", "Y10", "Y36","D144", "D12");
            data[7] = new MachineState("BM8", "M67", "D64", "Y6", "Y34","D140", "D14");
            data[8] = new MachineState("BM9", "M68", "D66", "Y5", "Y33","D138", "D16");
            data[9] = new MachineState("BM10", "M69", "D68", "Y4", "Y32","D136", "D18");
            data[10] = new MachineState("GRI", "M70", "D70", "Y12", "Y40","D148", "D20");
            data[11] = new MachineState("2F1", "M71", "D72", "Y13", "Y41","D150", "D22");
            data[12] = new MachineState("2F2", "M72", "D74", "Y14", "Y42","D152", "D24");
            data[13] = new MachineState("2F3", "M73", "D76", "Y15", "Y43","D154", "D26");
            data[14] = new MachineState("2F4", "M74", "D78", "Y16", "Y44","D156", "D28");
            data[15] = new MachineState("2F5", "M75", "D80", "Y17", "Y45","D158", "D30");
            data[16] = new MachineState("2F6", "M76", "D82", "Y20", "Y46","D160", "D32");
            data[17] = new MachineState("2F7", "M77", "D84", "Y21", "Y47","D162", "D34");
            data[18] = new MachineState("2F8", "M78", "D86", "Y22", "Y50","D164", "D36");
            data[19] = new MachineState("2F9", "M79", "D88", "Y23", "Y51","D166", "D38");
            data[20] = new MachineState("2F10", "M80", "D90", "Y24", "Y52","D168", "D40");
            data[21] = new MachineState("2F11", "M81", "D92", "Y62", "Y70","D172", "D42");
            data[22] = new MachineState("2F12", "M82", "D94", "Y63", "Y71","D174", "D44");
            data[23] = new MachineState("2F13", "M83", "D96", "Y64", "Y72","D176", "D46");
            data[24] = new MachineState("KAB", "M84", "D98", "Y25", "Y53","D170", "D48");
            data[25] = new MachineState("", "", "", "", "", "D178", "D50");
            data[26] = new MachineState("", "", "", "", "", "D180", "D52");
            data[27] = new MachineState("", "", "", "", "", "D182", "D54");
            data[28] = new MachineState("", "", "", "", "", "D184", "D56");
            data[29] = new MachineState("", "", "", "", "", "D186", "D58");

            return data;

        }
    }
}
