using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Radio
    {
        private int volume;
        private double frequenz;
        private bool onOff;

        public int Volume
        {
            get { return volume; }
            set {
                if (value >= 0 && value <= 100)  //validerar indata
                    volume = value;
                else
                    throw new Exception("Max volume is 100");
            }
        }
        public double Frequenz
        {
            get { return frequenz; }
            set {
                if (value >= 80 && value <= 120)  //validerar indata
                    frequenz = value;
                else
                    throw new Exception("The frequenze is between 80 and 120");
            }
        }
        public bool OnOff
        {
            get { return onOff; }
            set {
                if(value == false)
                    onOff = value; 
            else
            throw new Exception("The Radio is on");
            }
        }

        //public Radio()
        //{
        //    Volume = 35;
        //    Frequenz = 102.6;
        //    OnOff = false;
        //}

        public override string ToString() => $"Volume is: {volume} and the frequenze is: {Frequenz} and the radio is OFF.";
    }
}
