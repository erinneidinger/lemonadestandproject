using System;
using System.Collections.Generic;

namespace LemonadeStand_3DayStarter
{
    public class Game
    {
        Player player;
        List<Day> days = new List<Day>();
        Store store;
        int currentDay;
        

        public Game()
        {
            player = new Player();
            store = new Store();

            player.ChooseName();
            BuildDays();
            PlayGameForWeek();
        }
        public void ListInstructions()
        {

        }

        public void StartGame()
        {
            PlayGameForWeek();
        }
        public void PlayGameForWeek()
        {
            for (int i = 0; i < 7; i++)
            {
                days[i].RunDay(player, store);
            }
        }

        public void BuildDays()
        {
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day(player);
                days.Add(day);
            }
        }
    }
}
