using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        public Recipe()
        {
        }
        public void AddingAmountOfLemons(Inventory inventory)
        {
            Console.WriteLine("How many lemons would you like to add to your recipe?");
            amountOfLemons = Convert.ToInt32(Console.ReadLine());
            if(amountOfLemons > inventory.lemons.Count)
            {
                Console.WriteLine("Whoops, you don't have that many lemons in your inventory. Please add an amount that is equal or less than what you bought.");
                AddingAmountOfLemons(inventory);
            }
            else
            {
                Console.WriteLine("You added " + amountOfLemons + " lemons to your recipe.");
            }
        }
        public void AddingAmountOfSugarCubes(Inventory inventory)
        {
            Console.WriteLine("How many sugar cubes would you like to add to your recipe?");
            amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            if (amountOfSugarCubes > inventory.sugarCubes.Count)
            {
                Console.WriteLine("Whoops, you don't have that many sugar cubes in your inventory. Please add an amount that is equal or less than what you bought.");
                AddingAmountOfSugarCubes(inventory);
            }
            else
            {
                Console.WriteLine("You added " + amountOfSugarCubes + " sugar cubes to your recipe.");
            }
        }
        public void AddingAmountOfIceCubes(Inventory inventory)
        {
            Console.WriteLine("How many ice cubes would you like to add to your recipe? (Type how many you would like per cup)");
            amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
            amountOfIceCubes *= 12;
            if (amountOfIceCubes > inventory.iceCubes.Count)
            {
                Console.WriteLine("Whoops, you don't have that many ice cubes in your inventory. Please add an amount that is equal or less than what you bought.");
                AddingAmountOfIceCubes(inventory);
            }
            else
            {
                Console.WriteLine("You added " + amountOfIceCubes + " ice cubes to your recipe.");
            }
        }
        public void DeterminePricePerCup()
        {
            Console.WriteLine("Please write the price per cup (in cents):");
            pricePerCup = Convert.ToDouble(Console.ReadLine());
            pricePerCup /= 100; 
            Console.WriteLine("Your lemonade costs " + pricePerCup + " cents.");
        }
    }
}
