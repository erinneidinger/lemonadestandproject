using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class UserInterface
    {
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Lemons cost $0.25 cents each.");
                Console.WriteLine("Sugar cubes cost $0.05 cents each.");
                Console.WriteLine("Ice cubes cost $0.01 cents each.");
                Console.WriteLine("Cups cost $0.15 cents each.");

                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        //input the recipe userinterface functions, how many would player like to include in their recipe. 
    }
}
