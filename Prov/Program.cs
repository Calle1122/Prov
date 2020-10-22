using System;
using System.Collections.Generic;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar en instans av klassen Book.
            Book newItem = new Book();

            //Skapar en instans av klassen Customer.
            Customer newCustomer = new Customer();

            //Skriver inledande rader som förklarar att en kund har anlänt.
            Console.WriteLine("A new customer just arrived.");
            Console.WriteLine();

            //Följande rad skriver ut instansens, av Customer, "stats".
            newCustomer.PrintCustomer();

            //Skriver inledande rader som förklarar vad för föremål kunden tagit med sig.
            Console.WriteLine("They brought the following item:");
            Console.WriteLine();

            //Följande rad skriver ut instansens, av Book, "stats".
            newItem.PrintInfo();

            //En ReadLine för att programmet inte ska avslutas utan att användaren klickar ENTER.
            Console.ReadLine();
        }
    }
}
