using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Car
    {
        //Backingfields
        private int gears;
        private string brand;
        private string color;
        private string typeOfCar;

        //Properties
        public int Gears
        {
            get { return gears; }
            set { gears = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string TypeOfCar
        {
            get { return typeOfCar; }
            set
            {
                var validBrands = value == "coupe" || value == "combi";
                if (validBrands)
                    typeOfCar = value;
                else
                    throw new Exception("The type of the car is wrong, it must be coupe or combi");
            }
        }

        //Konstruktor

        public Car(int gears, string brand, string color, string typeOfCar)
        {
            Gears = gears;
            Brand = brand;
            Color = color;
            TypeOfCar = typeOfCar;          
        }

        public Car()
        {
            //Basklasser bör alltid ha en tom konstruktor! 
        }

        public void Drive()
        {
            Console.WriteLine("brum brum");
            
        }
        //ToString
        public override string ToString() => $"Brand: {Brand} Color: {Color} Type of car: {TypeOfCar} Number of gears: {Gears}";
        
        }
  }
    
   