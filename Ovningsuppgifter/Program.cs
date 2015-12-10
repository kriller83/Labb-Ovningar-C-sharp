using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningsuppgifter
{
    class Program
    {
        static int[] numbers = new int[20];  //vi deklarerar att datatypen är int

        static void Main(string[] args)
        {

            //ReadUserDataToArray();
            //PrintArray();
            //Uppgift1();
            //Uppgift2();
            //Uppgift3();
            //Uppgift4();
            //Uppgift5();
            //Uppgift6();
            //Uppgift7();
            //Uppgift8();
            //Uppgift9();
            //Uppgift10();
            //Uppgift11();
            //Uppgift12();
            //Uppgift13();
            //Uppgift14();
            //Uppgift15();
            //Uppgift16();
            //Uppgift17();  //????
            //Uppgift18();  //ej färdig
            //Uppgift19();    //ej färdig
            //Uppgift20();
            //Uppgift21();  //ej färdig
            //Uppgift22();  //ej färdig
            //Uppgift23();
            //Uppgift24();
            //Uppgift25();  //Fattar ej
            //Uppgift26();   //något fel här...
            //Uppgift27-29 = flödesscheman
            //Uppgift30();
            //Uppgift31();
            //Uppgift32();
            //Uppgift33();
            //Uppgift34();
            //Uppgift35();
            //Uppgift36();
            //Uppgift37();
            //Uppgift38();
            //Uppgift39();
            Uppgift40();


        }

        private static void Uppgift40()
        {
            Console.WriteLine("Skriv in ett tal");
            int tal = int.Parse(Console.ReadLine());
            if (tal >= 0 && tal <= 4 || tal >= 6 && tal <= 9)
                Console.WriteLine("Talet är mellan 0 och 9, men inte 5");
            else if( tal == 5)
                Console.WriteLine("Talet är 5");
           else
                Console.WriteLine("Talet är inte mellan 0 och 9 och inte heller 5");
        }

        private static void Uppgift39()
        {
            Console.WriteLine("Skriv in ett tal");
            int tal = int.Parse(Console.ReadLine());
            if (tal >= 0 && tal <= 9)
                Console.WriteLine("Talet är mellan 0 och 9");
            else
                Console.WriteLine("Talet är inte mellan 0 och 9");
        }

        private static void Uppgift38()
        {
            Console.WriteLine("Skriv in ett tal");
            int tal = int.Parse(Console.ReadLine());
            if (tal > 0)
                Console.WriteLine("Talet är positivt");
            else if (tal == 0)
                Console.WriteLine("Talet är neutralt");
            else
                Console.WriteLine("Talet är negativt");
        }

        private static void Uppgift37()
        {
            Console.WriteLine("Skriv värdet på variablen I");
            int I = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv värdet på K");
            int K = int.Parse(Console.ReadLine());
            if (I > (5 + K))
                Console.WriteLine("X = 2");
            else
                Console.WriteLine("Y = 5");

        }

        private static void Uppgift36()
        {
            Console.WriteLine("Skriv ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett tal till");
            int tal2 = int.Parse(Console.ReadLine());
            if (tal1 > tal2)
                Console.WriteLine($"{tal1}");
            else
                Console.WriteLine($"{tal2}");
        }

        private static void Uppgift35()
        {
            Console.WriteLine("Skriv ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett tal till");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett tal till");
            int tal3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Summan av talen blir {tal1 + tal2 + tal3}");
        }

        private static void Uppgift34()
        {
            Console.WriteLine("Skriv antalet liter");
            double liter = double.Parse(Console.ReadLine());
            double pris = 15.50;
            if (liter > 30)
                Console.WriteLine($"Du får 10% rabatt och ditt pris blir {liter * pris * 0.9}");
            else
                Console.WriteLine($"Ditt pris blir {pris * liter}");
        }

        private static void Uppgift33()
        {
            Console.WriteLine("Skriv in din temperatur i Fahrenheit");
            double temp = double.Parse(Console.ReadLine());
            double celcius = ((temp - 32) * (5.0 / 9.0));
            Console.WriteLine($"Temperaturen i Celsius blir {celcius}");
        }

        private static void Uppgift32()
        {
            Console.WriteLine("Skriv in höjden på rektanglen");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in längden på rektanglen");
            int tal2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"Arean av rektangeln blir {tal1 * tal2}");
        }

        private static void Uppgift31()
        {
            Console.WriteLine("Skriv ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett tal till");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplicering av talen blir {tal1 * tal2}");
        }

        private static void Uppgift30()
        {
            Console.WriteLine("Skriv ett tal");
            int tal = int.Parse(Console.ReadLine());

            Console.WriteLine($"Kvadraten på talet blir {tal * tal}");
        }

        protected void Uppgift26()
        {
            Console.Write("Skriv täljaren:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in nämnaren");
            int secondNumber = int.Parse(Console.ReadLine());

            while (secondNumber == 0)
            {
                Console.WriteLine("Nämnaren får inte vara noll");
                secondNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{firstNumber}/{secondNumber}={(double)firstNumber / (double)secondNumber}");

        }
       

        private static void Uppgift25()
        {
            int[] myArray = new int[50];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Heltalen är {myArray[i]}");
            }


        }

        private static void Uppgift24()
        {
            int[] myArray = new int[50];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
                if (i % 2 == 0)
                {
                    Console.WriteLine("(Adderas med 2: " + (myArray[i] +2));
        }
        else
        {
        Console.WriteLine(myArray[i]);
        }
}
}


        private static void Uppgift23()
        {
            int[] myArray = new int[50];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i * i;
                Console.WriteLine(myArray[i]);
            }
        }

        private static void Uppgift22()
        {
            throw new NotImplementedException();
        }

        private static void Uppgift21()
        {
            throw new NotImplementedException();
        }

        private static void Uppgift20()
        {
            List<int> helTal = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Fyll i ett tal:");
                helTal.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Totala värdet av dina tal är{helTal.Sum()}.");
            Console.ReadLine();
        }

        private static void Uppgift19()
        {
            int sum;

            for (int i = 0; i < 50; i++)
            {
                sum = i + i;
                Console.WriteLine($"Totala summan blir {sum}");
            }
        }

        private static void Uppgift18()
        {
            double deposit;
            for (double i = 1000; i >= 10; i++)
            {
                deposit = i * 1.05;
                Console.WriteLine(deposit);
                Console.ReadKey();

            }
        }

        private static void Uppgift17()
        {
            int square;
            for (int i = 1; i < 10; i++)
            {
                square = i * i;
                Console.WriteLine(square);
                Console.ReadKey();
            }
        }

        private static void Uppgift16()
        {
            char character;
            do
            {
                Console.WriteLine("Type a character('*' to escape):");
                character = Console.ReadKey().KeyChar;
                Console.WriteLine($"\nCharacter is\'{character}\'.");
            } while (character != '*');
        }

        private static void Uppgift15()
        {
            for (int i = 100; i >=0; i--)
            {
                Console.WriteLine(i);
            }
        }

        private static void Uppgift14()
        {
            for (int i = 2; i <= 100; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);
        }

        private static void Uppgift13()
        {
            //se flödesschema
        }

        private static void Uppgift12()
        {
            Console.WriteLine("Hur många enheter vill du ha?");
            int tal1 = int.Parse(Console.ReadLine());
            int pris = 200;
            int sum = pris * tal1;
            if (sum > 1000)
                Console.WriteLine ($"Summan blir {sum * 0.9}");
            else
                Console.WriteLine($"priset blir { sum} ..Du får ingen rabatt");
        }

        private static void Uppgift11()
        {
            Console.WriteLine("Skriv ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett tal till");
            int tal2 = int.Parse(Console.ReadLine());
            if(tal1 % tal2 == 0)
                Console.WriteLine("Första talet är jämnt delbart med andra talet");
            else
                Console.WriteLine("Första talet är inte jämnt delbart med andra talet");
        }

        private static void Uppgift10()
        {
            while (true) { 
            Console.WriteLine("Skriv ett tal");
            int tal = int.Parse(Console.ReadLine());
            if (tal % 2 == 0)
                Console.WriteLine("Jämnt tal");
            else
                Console.WriteLine("Udda tal");
            }
        }

        private static void Uppgift9()
        {
            Console.WriteLine("Skriv ett tal");
            int tal = int.Parse(Console.ReadLine());
            if (tal % 3 == 0)
                Console.WriteLine("talet är jämnt delbart med 3");
            else
                Console.WriteLine("Talet är inte jämnt delbart med tre");
        }

        private static void Uppgift8()
        {
            Console.WriteLine("Skriv ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett tal till");
            int tal2 = int.Parse(Console.ReadLine());
            if (tal1 > (tal2 + tal2))
                Console.WriteLine("För stort tal!");
            else
                Console.WriteLine("Bra tal :)");
        }
      
        private static void Uppgift7()
        {
            Console.WriteLine("Skriv ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett tal till");
            int tal2 = int.Parse(Console.ReadLine());
            if (tal1 > tal2) 
            Console.WriteLine(tal1 + " var störst");
            else{
                Console.WriteLine(tal2 + " var störst");
            }           
        }

        //Val och Alternativ
        private static void Uppgift6()
        {
            Console.WriteLine("Skriv ett heltal");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ytterligare ett heltal");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Funtionen ax3+7 är:" + (a * x) * (3 + 7));
        }

        private static void Uppgift5()
        {
            Console.WriteLine("Skriv ett tal");
            double kronor = int.Parse(Console.ReadLine());
            Console.WriteLine($"Summan i svenska kronor blir i pund: {kronor/12 :F2} och i Dollar: { kronor/6 :F2}");
        }

        private static void Uppgift4()
        {
            //Console.WriteLine("skriv ett tal");
            //double number1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("skriv ett tal");
            //double number2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("skriv ett tal");
            //double number3 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Sum is" + (number1 + number2 + number3));
            //Console.WriteLine("average is" + (number1 + number2 + number3) / 3);

            Console.WriteLine("How many numbers do you want to calculate");
            int iterations = int.Parse(Console.ReadLine());
            int[] number = new int[iterations];
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("Write a number");
                number[i] = int.Parse(Console.ReadLine());
                    }
            double summa = 0;
            for (int i = 0; i < number.Length; i++)
            {
                summa += number[i];
            }
            Console.WriteLine("The sum is: {0} and average is: {1}", summa, summa/numbers.Length);

        }

        private static void Uppgift3()
        {
            Console.WriteLine("Skriv ett antal timmar tackarrr");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine("Antal minuter är:" + tal * 60);
            Console.WriteLine("Antal sekunder är:" + tal * 60 * 60);

            Console.WriteLine("Skriv ett antal timmar tackarrr");
            int hours = int.Parse(Console.ReadLine());
            int minutes = hours * 60;
            int seconds = minutes * 60;
            Console.WriteLine("Antal minuter är:" + minutes + "och antal sekunder är" + seconds);

        }

        private static void Uppgift2()
        {
            Console.WriteLine("Skriv in försäljningssumma");
            int salary = 15000;
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lönen är:" + ((tal1 * 0.09) + salary));
        }

        private static void Uppgift1()
        {
            Console.WriteLine("Skriv ett tal som motsvarar sidan på en kvadrat:");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine("Arean är:" + tal * tal);
        }

        private static void ReadUserDataToArray()
        {
          
            for (int i = 0; 1 < numbers.Length; i++)  
            {
                Console.WriteLine("Skriv in ett tal");
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
        private static void PrintArray()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

