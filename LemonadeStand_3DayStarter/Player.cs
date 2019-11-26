using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
   class Player
    {
        // member variables (HAS A)
        string name;
        public Inventory inventory;
        public Wallet wallet;
        public Pitcher pitcher;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        // member methods (CAN DO)
        public void ChooseName()
        {
            Console.WriteLine("Choose a name");
            name = Console.ReadLine();
            Console.WriteLine("Your name is " + name + ".");
            Console.ReadLine();
        }
    }
}
