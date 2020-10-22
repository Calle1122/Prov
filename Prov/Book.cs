using System;
using System.Collections.Generic;

namespace Prov
{
    public class Book
    {
        //variabel för pris
        public int price;
        //variabel för namn
        private string name;
        //variabel för rarity
        private int rarity;
        //variabel för kategori
        private string category;
        //variabel för det faktiska värdet
        private int actualValue;
        //ifall itemet är cursed eller inte
        private bool cursed;
        //en slumpgenerator
        private Random generator = new Random();
        //en lista för möjliga namn på items
        private List<string> items = new List<string>() {"Dark Book", "Ancient Map", "Shiny Relic", "Old Ritual Texts"};
        //en lista för möjliga kategorier på items
        private List<string> categories = new List<string>() {"Very Old Item", "Gold Dipped Item", "Mythical Item", "Forgotten Item"};

        public Book(){
            //Slumpar värde för value mellan 10-10000.
            actualValue = generator.Next(10, 10001);
            //Slumpar värde för rarity mellan 1-100.
            rarity = generator.Next(1, 101);

            int cursedInt = generator.Next(1,3);

            if(cursedInt == 1){
                cursed = false;
            }

            else if(cursedInt == 2){
                cursed = true;
            }

            int generatedName = generator.Next(0, items.Count);
            int generatedCategory = generator.Next(0, categories.Count);

            name = items[generatedName];
            category = categories[generatedCategory];

        }

        public void PrintInfo(){
            Console.WriteLine("Item Name: " + name);
            Console.WriteLine("Item Category: " + category);
            Console.WriteLine("Item Rarity: " + rarity + "% rare");
            Console.WriteLine("Item Price: " + actualValue + " $");
        }

        public int Evaluate(){
            int rightPrice;

            rightPrice = actualValue * rarity;

            int percentage = generator.Next(50, 151);

            rightPrice = rightPrice/100;
            rightPrice = rightPrice * percentage;

            return rightPrice;
        }

        public string GetCategory(){
            return category;
        }

        public string GetName(){
            return name;
        }

        public bool IsCursed(){
            if(cursed == true){
                int risk = generator.Next(1,11);

                if(risk <3){
                    return false;
                }

                else{
                    return true;
                }
            }

            else if(cursed == false){
                int risk = generator.Next(1,11);

                if(risk <3){
                    return true;
                }

                else{
                    return false;
                }
            }

            // Detta kodblock kommer aldrig att köras.
            // Var bara tvungen att skriva det så att metoden inte blir arg.
            else{
                return true;
            }
        }
    }
}
