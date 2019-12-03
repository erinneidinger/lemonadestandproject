using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher
    {
        
        public int leftoverLemons;
        public int leftoverSugarcubes;
        public int leftoverIcecubes;
        public int cupsPerPitcher;
   
        public Pitcher()
        {
            cupsPerPitcher = 0;
        }

        public int FillPitcher(Inventory inventory, Recipe recipe, Store store, Player player)
        {
            inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
            inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
            inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes);
            inventory.cups.RemoveRange(0, recipe.amountOfCups);
            cupsPerPitcher = 12;

            return cupsPerPitcher;
        }

        public int RefillPitcher(Inventory inventory, Recipe recipe, Store store, Player player, Day day)
        {
            if (inventory.lemons.Count < recipe.amountOfLemons)
            {
                Console.WriteLine("You ran out of lemons. Sold out!");
                day.PostResults(player);
                store.GoToStore(player);
            }

            else if (inventory.iceCubes.Count < recipe.amountOfIceCubes)
            {
                Console.WriteLine("You ran out of ice cubes. Sold out!");
                day.PostResults(player);
                store.GoToStore(player);
            }
            else if (inventory.sugarCubes.Count < recipe.amountOfSugarCubes)
            {
                Console.WriteLine("You ran out of sugar cubes. Sold out!");
                day.PostResults(player);
                store.GoToStore(player);
            }
            else
            {
                Console.WriteLine("You ran out of cups. Sold out!");
                day.PostResults(player);
                store.GoToStore(player);
            }
            return cupsPerPitcher;
        }

        public void DisplayLeftoverInventory(Inventory inventory)
        {
            leftoverIcecubes = inventory.iceCubes.Count();
            leftoverLemons = inventory.lemons.Count();
            leftoverSugarcubes = inventory.sugarCubes.Count();
            Console.WriteLine("In your inventory, you have " + leftoverIcecubes + " ice cubes, " + leftoverLemons + " lemons, and " + leftoverSugarcubes + " sugar cubes left.");
        }
    }
}
