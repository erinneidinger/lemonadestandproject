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

        public Pitcher()
        {
            cupsLeftInPitcher = 12;
        }

        public void FillPitcher(Inventory inventory, Recipe recipe)
        {
            inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
            inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
            inventory.iceCubes.RemoveRange(0, 12 * recipe.amountOfIceCubes);
            Console.ReadLine();
        }  
    }
}
