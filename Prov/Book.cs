using System;

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
