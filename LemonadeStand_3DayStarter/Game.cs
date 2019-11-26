using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Game
    {
        Player player;
        List<Day> days;
        Store store;
        Recipe recipe;
        Wallet wallet = new Wallet();
        Inventory inventory = new Inventory();
        Pitcher pitcher = new Pitcher();
        Weather weather = new Weather();
        Day day = new Day();
        Customer customer = new Customer();

        int currentDay;

        public Game()
        {

        }
        public void ListInstructions()
        {

        }

        public void StartGame()
        {
            ListInstructions();
            player.ChooseName();
            store.SellLemons(player);

            
        }
    }
}
