using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Modellering_Alvin_Hagerback
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press enter to create a book!");
            Console.ReadLine();

            Books b1 = new Books();

            Customers c1 = new Customers();

            Console.Clear();

            bool LoopCheck = true;

            int BookPrice = 0;

            string BookName = "";

            string BookCategory = "";

            while (LoopCheck == true)
            {
                Console.Clear();
                Console.WriteLine("1. Get info  2. Get name  3. Get category 4. Evaluate book 5. Sell a book to a buyer. ");

                int playerchoice = MenuChoice(1, 5);

                if (playerchoice == 1)
                {
                    Console.Clear();
                    b1.PrintInfo();
                    Console.WriteLine("Press enter to go to the menu");
                    Console.ReadLine();
                }

                if (playerchoice == 2)
                {
                    Console.Clear();
                    BookName = b1.GetName();
                    Console.WriteLine("Name: " + BookName + "\nPress enter to go to the menu");
                    Console.ReadLine();
                }

                if (playerchoice == 3)
                {
                    Console.Clear();
                    BookCategory = b1.GetCategory();
                    Console.WriteLine("Category: " + BookCategory + "\nPress enter to go to the menu");
                    Console.ReadLine();
                }

                if (playerchoice == 4)
                {
                    Console.Clear();
                    BookPrice = b1.Evaluate();
                    Console.WriteLine("The value of the book is: " + BookPrice + "\nPress enter to go to the menu");
                    Console.ReadLine();
                }

                if (playerchoice == 5)
                {
                    Console.Clear();

                    Console.WriteLine("The name of the buyer is: " + c1.name + " and he/she has " + c1.money + " dollars.");

                    if (c1.money == BookPrice || c1.money > BookPrice)
                    {
                        c1.money = c1.money - BookPrice;
                        Console.WriteLine(c1.name + " buys the book and now has " + c1.money + " dollars left.");
                    }
                    else
                    {
                        Console.WriteLine(c1.name + " cannot afford the book.");
                    }

                    Console.WriteLine("Press enter to go to the menu");
                    Console.ReadLine();
                }


            }


        }

        public static int MenuChoice(int lowest, int highest)
        {
            Console.WriteLine("Choose a number between " + lowest + "and " + highest + "and press enter.");

            bool PlayerInputCheck = false;

            int PlayerInput = 0;

            while (PlayerInputCheck == false)
            {
                int.TryParse(Console.ReadLine(), out PlayerInput);

                if (PlayerInput == 0)
                {
                    Console.WriteLine("Please choose a number between " + lowest + " and " + highest + ".");
                    int.TryParse(Console.ReadLine(), out PlayerInput);
                }

                if (PlayerInput > lowest - 1 && PlayerInput < highest + 1)
                {
                    return PlayerInput;
                }
            }

            return 1;
        }
    }
}
