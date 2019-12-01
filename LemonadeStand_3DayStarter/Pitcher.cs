using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher
    {
        public int cupsLeftInPitcher;
        public int leftoverLemons;
        public int leftoverSugarcubes;
        public int leftoverIcecubes;
   
        public Pitcher()
        {
            cupsLeftInPitcher = 12;
        }

        public void FillPitcher(Inventory inventory, Recipe recipe)
        {
            inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
            inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
            inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes);
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
