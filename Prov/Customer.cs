using System;
using System.Collections.Generic;

namespace Prov
{
    //Hela denna klass är gjord efter egna tankar.
    //Klass-schema (eller vad det hette) finns bifogat i Classroom uppgiften.
    //Alla variabler och metoders mening finns skrivet nedan i kommentarer.
    public class Customer
    {
        //Variabel för att storea kundens namn.
        public string name;

        //Variabel för att storea kundens ålder.
        private int age;

        //Variabel för att storea kundens pengar.
        private int money;

        //Variabel för att storea kundens nature (greedy / non greedy).
        private bool greedy;

        //Random generator.
        private Random generator = new Random();

        //Lista med olika möjliga kundnamn.
        //Inte alls familiar names :)
        private List<string> names = new List<string>() {"Fred", "Welma", "Shaggy", "Daphnie", "Scoob"};

        //Konstruktorn slumpar kundens namn från en lista.
        //Slumpar även age, money och nature (greedy eller inte greedy).
        public Customer(){
            int chosenName = generator.Next(0, names.Count);
            name = names[chosenName];

            //Slumpar ålder mellan 20-95 år.
            age = generator.Next(20, 96);

            //Slumpar money mellan 10-100 000 $.
            money = generator.Next(10, 100000);

            //Följande kod i metoden slumpar ifall kunden är greedy eller inte.
            //Slumpar ett tal mellan 1-2.
            int isGreedy = generator.Next(1,3);

            //Ifall värdet blev 1 så är kunden inte greedy.
            if(isGreedy == 1){
                greedy = false;
            }

            //Ifall värdet blev 2 så är kunden greedy.
            else if(isGreedy == 2){
                greedy = true;
            }
        }

        //Tanken med denna metod är att den ska skriva ut kundens namn, ålder och pengar.
        //Den skriver även ut kundens nature, greedy eller inte (true / false).
        public void PrintCustomer(){
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Customer Age: " + age);
            Console.WriteLine("Customer Balance: " + money + " $");
            Console.WriteLine("Is Greedy: " + greedy);
        }
    }
}
