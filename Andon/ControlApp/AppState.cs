using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActUtlTypeLib;
using Bunifu.Framework.UI;
using System.Windows.Forms;
namespace Andon.ControlApp
{
    public class AppState
    {
        public static bool PageConnect { get; set; }
        public static bool PageSlide { get; set; }
        public static bool PageSreenDiplay { get; set; }
        public static bool StatusHorn { get; set; }
        public static bool StatusRecord { get; set; }
        public static bool StatusConnect  { get; set; }
        public static bool FlagCleanScreen { get; set; }
        public static int Count { get; set; }
        public static BunifuThinButton2[] Button { get; set; }
        public static GroupBox[] GroupBox1 { get; set; }
    }
    
}
