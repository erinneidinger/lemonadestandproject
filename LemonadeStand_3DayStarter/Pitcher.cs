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
        public int leftoverlemons;
        public int leftoversugarcubes;
        public int leftovericecubes;
        public Pitcher()
        {
            cupsLeftInPitcher = 0;
        }

        public void FillPitcher(Inventory inventory, Recipe recipe)
        {
            inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
            inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
            inventory.iceCubes.RemoveRange(0, 12 * recipe.amountOfIceCubes);
            cupsLeftInPitcher = 12;
        }  
        public void DisplayLeftoverInventory(Inventory inventory)
        {
            leftovericecubes = inventory.iceCubes.Count();
            leftoverlemons = inventory.lemons.Count();
            leftoversugarcubes = inventory.sugarCubes.Count();
            Console.WriteLine("In your inventory, you have " + leftovericecubes + " ice cubes, " + leftoverlemons + " lemons, and " + leftoversugarcubes + " sugar cubes left.");
        }
    }
}
