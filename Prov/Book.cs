using System;
using System.Collections.Generic;

namespace Prov
{
    public class Book
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator = new Random();
        private List<string> items = new List<string>() {"Dark Book", "Ancient Map", "Shiny Relic", "Old Ritual Texts"};
        private List<string> categories = new List<string>() {"Very Old Item", "Gold Dipped Item", "Mythical Item", "Forgotten Item"};

        public Book(){
            actualValue = generator.Next();
            rarity = generator.Next();

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
            Console.WriteLine("Item Rarity: " + rarity);
            Console.WriteLine("Item Price: " + price);
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
