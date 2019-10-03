using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Modellering_Alvin_Hagerback
{
    class Books
    {
        public List<string> BookList = new List<string>() { "Legend of Zarnia", "Polymorphing 101", "My Mount and Me" };

        public List<string> CategoryList = new List<string>() { "Biography", "Fantasy", "Encyclopedia" };

        public int price = 0;

        string name = "";

        int rarity = 0;

        string category = "";

        int actualValue = 0;

        bool cursed = false;

        int RandomCheck = 0;

        Random generator = new Random();

        public Books()
        {
            rarity = generator.Next(6);
            cursed = IsCursed();
            actualValue = generator.Next(101);
            name = BookList[generator.Next(3)];
            category = CategoryList[generator.Next(3)];
            price = generator.Next(0, 300);

        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name + "  Rarity: " + rarity + "/5  Category: " + category + "  Price: " + price);
            if (cursed == true)
            {
                Console.WriteLine("The book is cursed! Proceed with caution...");
            }
        }

        public int Evaluate()
        {
            price = rarity * actualValue;

            RandomCheck = generator.Next(2);

            if (RandomCheck == 1)
            {
                return price * 2;
            }

            else if (RandomCheck == 0)
            {
                return price / 2;
            }

            return price;
        }

        public string GetCategory()
        {
            return category;
        }

        public string GetName()
        {           
            return name;
        }

        public bool IsCursed()
        {
            RandomCheck = generator.Next(5);

            if (RandomCheck < 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
