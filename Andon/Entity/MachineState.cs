using System;

namespace Andon.Entity
{
    public class MachineState
    {
        public string Name { get; set; }
        public string Address { get; set; } //Địa chỉ xảy ra tác động gây Downtime
        public int State { get; set; } = 1;
        public DateTime Date { get; set; } = DateTime.Now;
        public DateTime DateStart { get; set; }
        public double Downtime { get; set; }
        public bool FlagDown { get; set; } = false;
        ///////////////////////
        public string AddressTimer { get; set; } //Địa chỉ giá trị Downtime
        public double value { get; set; }
        public int Counter { get; set; }
    }
   
}
