using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class UserInterface
    {

        public static void ListInstructions()
        {

            Console.WriteLine("Welcome to Lemonade Stand! Your goal is to make a profit at your stand and bring in as much business as you can.");
            Console.WriteLine("First you will go to the store and buy your ingredients. Then you will add a certain amount to your recipe.  Remember to watch the forecast to see what the weather is for the upcoming day. More customers will want to buy lemonade if the weather is warm.");
            Console.WriteLine();
            Console.WriteLine("Lemons cost $0.25 cents each.");
            Console.WriteLine("Sugar cubes cost $0.05 cents each.");
            Console.WriteLine("Ice cubes cost $0.01 cents each.");
            Console.WriteLine("Cups cost $0.15 cents each.");
            Console.WriteLine();
            Console.WriteLine("Please enter a positive integer (or 0 to cancel):");
        }
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;


            while (!userInputIsAnInteger || quantityOfItem < 0)
            {

                    Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
        
                userInputIsAnInteger = Int32.TryParse(Console.ReadLine().Trim(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        //input the recipe userinterface functions, how many would player like to include in their recipe. 
    }
}
