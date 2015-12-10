using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Radio2
    {
        private int volume;
        private double frequenz;
        private bool isOff;
        static int instanceCount;

        public int Volume   //Property
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value <= 100)
                    volume = value;
                else
                    throw new Exception("Max volume is 100");
            }
        }
        public double Frequenz  //Property
        {
            get { return frequenz; }
            set
            {
                if (value >= 80 && value <= 120)
                    frequenz = value;
                else
                    throw new Exception("The frequenze is between 80 and 120");
            }
        }
        public bool IsOff  //Property
        {
            get { return isOff; }
            set
            {
                isOff = value;
            }
        }
        public string RadioState
        {
            get
            {
                return IsOff ? "Off" : "On";
            }
        }

        //public bool onOff { get; set; }   Funkar detta? Behövs ej validera indata?
        public static int InstanceCount { get; private set; } //Property
        public string Name { get; set; }  //Property
        public int Model { get; set; }  //Property
        public Radio2()    //Konstruktor default

        {  
            Volume = 55;
            Frequenz = 103.4;
            IsOff = true;
            InstanceCount++;
        }
        public Radio2(int volume, double frequenz, bool IsOff) : this()  //Konstruktor
        {
            IsOff = isOff;
            Volume = volume;
            Frequenz = frequenz;
        }
        static Radio2()
        {
            InstanceCount = 0;
        }
        public override string ToString() => $"Volume is: {volume} and the frequenze is: {Frequenz} and the radio is {RadioState}. The name of the radio is {Name} and model number is {Model} Instancecount is : {InstanceCount}";
    }
}
