using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{

    //Titta extra mycket på this...!!!!
    class Quadbike
    {
        int wheels;
        double gasolineAmount;
        string color;
        int serialNumber;
        string modelName;
        int horsepowers;
        bool wifiIsAvailable;
        static int numberOfQuads;

        public int Wheels
        {
            get { return wheels; } //Behövs detta?
            set { wheels = value; }
        }
        public double GasolineAmount
        {
            get { return gasolineAmount; }
            set
            {
                if (value >= 50 && value <= 70)
                    gasolineAmount = value;
                else
                    throw new Exception("The amount of gasoline is between 50 and 70 litres");
            }
        }
        public string Color
        {
            get { return color; }
            set {
                if (value == "White" || value == "Green" || value == "Black" || value == "Red")
                    color = value;
                else
                    throw new Exception("Not a valid color");
            }
        }
        public int SerialNumber { get; set; }
        public string ModelName { get; set; }
        public int Horsepowers
        {
            get { return horsepowers; }
            set
            {
                if (value >= 70 && value <= 150)
                    horsepowers = value;
                else
                    throw new Exception("Number of horsepowers are between 70 and 150");
            }
        }
        public bool WifiIsAvailable
        {
            get { return wifiIsAvailable; }
            set
            {
                wifiIsAvailable = value;    
            }            
        }
        public string QuadWifi
        {
            get
            {
                return WifiIsAvailable ? "is available" : "not available";
            }
        }
        public static int NumberOfQuads { get; private set; }

        public Quadbike()
        {
            Wheels = 4;
            GasolineAmount = 60.5;
            Color = "Black";
            SerialNumber = serialNumber;
            ModelName = "CF Moto";
            Horsepowers = 90;
            WifiIsAvailable = true;
            NumberOfQuads++;
        }

        public override string ToString() => $"Quadbike number: {NumberOfQuads}.\r\nThe quadbike has {Wheels} wheels. The amount of gasoline is {GasolineAmount}. The color of the ATV is {Color}, and the serialnumber is {SerialNumber} and model is {ModelName}. The amount of horsepowers are {Horsepowers}. Wifi {QuadWifi}.\r\n Total number of ATV's are {NumberOfQuads}";

    }
}
