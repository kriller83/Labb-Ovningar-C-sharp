using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Program
    {
        //Titta extra mycket på this..!!! 
        static void Main(string[] args)
        {
            try
            {
                //CarMethod();
                //RadioMethod();
                //Radio2Method();
                //CycleMethod();
                //QuadbikeMethod();

                SUV secondSUV = new SUV();
                secondSUV.Drive();
                Car secondCar = new Car();
                secondCar.Drive();


                SUV mySUV = new SUV();
                mySUV.Drive();
                Car newcar = mySUV;
                newcar.Drive();
                


                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.InnerException);
            }


        }

        private static void QuadbikeMethod()
        {
            Quadbike myQuad = new Quadbike() { SerialNumber = 4545 };
            Console.WriteLine(myQuad);
            Quadbike myQuad2 = new Quadbike() { SerialNumber = 5050, Color = "White" };
            Console.WriteLine(myQuad2);
            Quadbike myQuad3 = new Quadbike() { SerialNumber = 6060, Color = "Green", GasolineAmount = 60, Wheels = 3, Horsepowers = 110, WifiIsAvailable = false };
            Console.WriteLine(myQuad3);
        }

        private static void CycleMethod()
        {
            Cycle myCycle = new Cycle() { Clock = true };
            Console.WriteLine(myCycle);
            Cycle myCycle2 = new Cycle("Kawasaki");
            Console.WriteLine(myCycle2);
            Cycle myCycle3 = new Cycle("Green", 5);
            Console.WriteLine(myCycle3);
            Cycle myCycle4 = new Cycle("Hotpink", "Titanium");
            Console.WriteLine(myCycle4);
            Console.WriteLine("Number of bicycles " + Cycle.CycleCount);
        }

        private static void Radio2Method()
        {
            Radio2 mySecondRadio = new Radio2() { Name = "Krilles radio", Model = 5467546 };    //Object initializer
            Console.WriteLine(mySecondRadio);
            Radio2 mySecondRadio2 = new Radio2() { Volume = 60, Name = "Krilles SuperRadio", Model = 6669999, IsOff = false };
            Console.WriteLine(mySecondRadio2);
            Console.WriteLine("Number of radios " + Radio2.InstanceCount);
            
        }

        private static void RadioMethod()
        {
            Radio myRadio = new Radio();
            Console.WriteLine(myRadio);
        }

        private static void CarMethod()
        {
            Car myCarType = new Car(6, "Opel", "Blue", "coupe");
            Console.WriteLine(myCarType);
            Console.ReadLine();
        }
    }
}
