using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    //Kolla this här i konstruktorerna..
    class Cycle
    {
        //string name;  ..behövs ej
        //string color;  ..behövs ej
        int cycleGears;
        string types;
        static int cycleCount = 1;  //Behövs ej
        bool clock;

        public string Name { get; set; } //Property som inte arbetar mot backingfield

        public string Color { get; set; } //Property som inte arbetar mot backingfield

        public static int CycleCount { get; private set; }

        public int CycleGears
        {
            get { return cycleGears; }
            set
            {
                if (value >= 1 && value <= 10)
                    cycleGears = value;
                else
                    throw new Exception("Not a valid gear");
            }
        }  //Property som arbetar mot backingfield = valideras.
        public string Types
        {
            get { return types; }
            set
            {
                if (value == "Steel" || value == "Aluminum" || value == "Titanium")
                    types = value;
                else
                    throw new Exception("Not a valid type");
            }

        }  //Property som arbetar mot backingfield = valideras.

        public bool Clock
        {
            get { return clock; }
            set
            {
                if (value == true)
                {
                    clock = value;
                    Console.Beep(6000, 1000);
                    value = false;
                }
                else
                {
                    throw new Exception("Klockan funkar ej");
                }
            }
        }

        public Cycle()
        {
            Name = "Cresent";
            Color = "Blue";
            CycleGears = 10;
            Types = "Steel";
            CycleCount = cycleCount++;
        }
        public Cycle(string name) : this()
        {
            Name = name;
            Color = "Red";
            CycleGears = 8;
            Types = "Aluminum";
        }
        public Cycle(string color, int cycleGears) : this()
        {
            Name = "Honda";
            Color = color;
            CycleGears = cycleGears;
            Types = "Aluminum";
        }
        public Cycle(string color, string types) : this()
        {
            Name = "Honda";
            Color = color;
            CycleGears = 6;
            Types = types;
        }
        //static Cycle()
        //{
        //    CycleCount = 0;
        //}
        public override string ToString()
        {
            return $"Name: {Name} Color: {Color} Gears: {CycleGears} Type of bike: {Types} Bicycle number: {CycleCount}. The bell goes beeeep! {Clock}";
        }
    }
}
