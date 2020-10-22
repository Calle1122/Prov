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

        }

        public int Evaluate(){

        }

        public string GetCategory(){

        }

        public string GetName(){

        }

        public bool IsCursed(){

        }
    }
}
