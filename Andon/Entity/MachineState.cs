using System;

namespace Andon.Entity
{
    public class MachineState
    {
        public string Name { get; set; }
        public string Address { get; set; } //Địa chỉ xảy ra tác động gây Downtime
        public int State { get; set; } 
        public DateTime Date { get; set; }
        public DateTime DateStart { get; set; }
        public double Downtime { get; set; }
        public bool FlagDown { get; set; }
        ///////////////////////
        public string AddressTimer { get; set; } //Địa chỉ giá trị Downtime
        public double value { get; set; }
        public int Counter { get; set; }
        public string AddressMaint { get; set; } //DisplayScreen
        public string AddressPro { get; set; } //DisplayScreen

        public MachineState()
        {

        }

        public MachineState(string name, string address, string addressTimer, string addressMaint, string addressPro)
        {
            Name = name;
            Address = address;
            State = 1;
            Date = DateTime.Now;
            FlagDown = false;
            AddressTimer = addressTimer;
            AddressMaint = addressMaint;
            AddressPro = addressPro;
        }
    }
   
}
