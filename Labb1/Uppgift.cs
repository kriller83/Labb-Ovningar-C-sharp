using System;


namespace Simple
{
    class Program          //declare a class
    {
        static void Main()
        {
            //Här använder jag mig av markörer och värden, där det tal som står i markören representerar värdets plats.
            Console.WriteLine("Nu skall vi testa integers! Första talet är {0} och andra talet är {1}.", 12, 15);
            Console.ReadLine();

            //Vi kan formatera våra strängar genom att exempelvis ge dem en valuta eller ett bestämt antal decimaler.
            Console.WriteLine("Vi kan ge värdet en valuta, exemeplvis: Jag får {0:C} varje månad", 9900);
            Console.ReadLine();
        }

    }
}
