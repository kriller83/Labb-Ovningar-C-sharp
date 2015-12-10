using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
  
    class Program
    {
        
        static void Main(string[] args)
        {
            //PersonMethod();
            //CircleMethod();
            //PointMethod();
            //CircleUpdate();

            Car volvo = new Car();
            Motorcycle ninja = new Motorcycle();
            volvo.SetModel("Volvo s40");
            ninja.SetModelMc("Kawasaki Ninja");
            Console.WriteLine("Hur många hästkrafter har du?");
            double myHorsepower = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur snabbt kör du?");
            double MySpeed = double.Parse(Console.ReadLine());
            Engine myEngine = new Engine();
            volvo.SetEngine(myEngine);
            ninja.SetEngine(myEngine);
            myEngine.SetHorsepowers(myHorsepower);
            myEngine.SetSpeed(MySpeed);
            //Console.WriteLine("Vad är din bränsleförbrukning?");
            //myEngine.SetFuelConsumption(double.Parse(Console.ReadLine()));         
            Console.WriteLine($"Förbrukningen för {volvo.GetModel()} är " + volvo.GetEngine().GetFuelConsumptionCar() + " liter per mil");
            Console.WriteLine($"Förbrukningen för {ninja.GetModel()} är " + ninja.GetEngine().GetFuelConsumptionMc() + " liter per mil");
        }

        private static void CircleUpdate()
        {
            //Circle myCircle = new Circle();
            //myCircle.SetDiameter(10);
            //Point myPoint = new Point();
            //myPoint.SetX(8);
            //myPoint.SetY(5);
            //myCircle.SetCenter(myPoint);

            //Console.WriteLine("X är " + myCircle.GetCenter().GetX());
            //Console.WriteLine("Y är " + myCircle.GetCenter().GetY());
            //Console.WriteLine("Diametern är" + myCircle.GetDiameter());
            //Console.WriteLine("Omkretsen är" + myCircle.GetCircumference());

            Random random = new Random();

            Circle[] myCircles = new Circle[1000];
            for (int i = 0, j = 369; i < myCircles.Length; i++, j += 7)
            {
                myCircles[i] = new Circle();
                myCircles[i].SetDiameter(j);
                var newPoint = new Point();
                newPoint.SetX(random.Next(0, 45));
                newPoint.SetY(random.Next(0, 45));
                myCircles[i].SetCenter(newPoint);

                //Console.WriteLine("X är " + myCircles[i].GetCenter().GetX());
                //Console.WriteLine("Y är " + myCircles[i].GetCenter().GetY());
                //Console.WriteLine("Diametern är" + myCircles[i].GetDiameter());
                //Console.WriteLine("Omkretsen är" + myCircles[i].GetCircumference());
                //Console.WriteLine();
            }

            foreach (var circle in myCircles)
            {
                //Console.WriteLine("X är " + circle.GetCenter().GetX());
                //Console.WriteLine("Y är " + circle.GetCenter().GetY());
                //Console.WriteLine("Diametern är" + circle.GetDiameter());
                //Console.WriteLine("Omkretsen är" + circle.GetCircumference());
                Console.WriteLine(circle.GetCircle());
                Console.WriteLine();
            }
        }

        private static void PointMethod()
        {
            Point myPoint = new Point();
            Console.WriteLine("Skriv värdet för x");
            int MyX = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv värdet för y");
            int MyY = int.Parse(Console.ReadLine());
            myPoint.SetX(MyX);
            myPoint.SetY(MyY);
            Console.WriteLine($"x blev" + myPoint.GetX() + "och y blev" + myPoint.GetY());
        }

        private static void CircleMethod()
        {
            Circle myCircle = new Circle();  //skapa ny instans av circle
            Console.WriteLine("Write diameter");   //Skriv in ett värde
            double MyDiameter = double.Parse(Console.ReadLine());  //Sparar värdet i en variabel
            myCircle.SetDiameter(MyDiameter); //Sätter värdet som skrevs in, i SetDiameter.
            Console.WriteLine("Omkretsen är: " + myCircle.GetCircumference());  //skriver ut GetCircumference
            Console.WriteLine("Diametern är: " + myCircle.GetDiameter());
        }

        private static void PersonMethod()
        {
            Person personOne = new Person();
            //person.GetName();
            string str = Console.ReadLine();
            personOne.SetName(str);
            Console.WriteLine("Ditt namn är:" + personOne.GetName());


            Person personTwo = new Person();
            personTwo.SetName(Console.ReadLine());
            Console.WriteLine("Ditt namn är" + personTwo.GetName());


            Person personThree = new Person();
            personThree.SetName(Console.ReadLine());
            Console.WriteLine("Namnet är: " + personThree.GetName());
        }
    }
}
