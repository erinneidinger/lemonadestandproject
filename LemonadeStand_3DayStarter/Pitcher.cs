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
        public int leftoverCups;
        public int cupsPerPitcher;
   
        public Pitcher()
        {
            cupsPerPitcher = 0;
        }

        public int FillPitcher(Player player)
        {
            player.inventory.lemons.RemoveRange(0, player.recipe.amountOfLemons);
            player.inventory.sugarCubes.RemoveRange(0, player.recipe.amountOfSugarCubes);
            player.inventory.iceCubes.RemoveRange(0, player.recipe.amountOfIceCubes);
            cupsPerPitcher = 12;

            return cupsPerPitcher;
        }

        public int RefillPitcher(Inventory inventory, Recipe recipe, Store store, Player player, Day day)
        {
            if (inventory.lemons.Count < recipe.amountOfLemons)
            {
                Console.WriteLine("You ran out of lemons. Sold out!");
                
            }

            else if (inventory.iceCubes.Count < recipe.amountOfIceCubes)
            {
                Console.WriteLine("You ran out of ice cubes. Sold out!");
                
            }
            else if (inventory.sugarCubes.Count < recipe.amountOfSugarCubes)
            {
                Console.WriteLine("You ran out of sugar cubes. Sold out!");
               
            }
            else if(inventory.cups.Count < recipe.amountOfCups)
            {
                Console.WriteLine("You ran out of cups. Sold out!");
                
            }
            else
            {
                FillPitcher(player);
            }
            return cupsPerPitcher;
        }

        public void DisplayLeftoverInventory(Inventory inventory)
        {
            leftoverIcecubes = inventory.iceCubes.Count();
            leftoverLemons = inventory.lemons.Count();
            leftoverSugarcubes = inventory.sugarCubes.Count();
            leftoverCups = inventory.cups.Count();
            Console.WriteLine("In your inventory, you have " + leftoverIcecubes + " ice cubes, " + leftoverLemons + " lemons, " + leftoverSugarcubes + " sugar cubes and " + leftoverCups + "cups left.");
        }
    }
}
