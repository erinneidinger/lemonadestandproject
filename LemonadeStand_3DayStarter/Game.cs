using System;
using System.Collections.Generic;

namespace LemonadeStand_3DayStarter
{
    public class Game
    {
        Random random;
        Player player;
        List<Day> days = new List<Day>();
        Day day;
        Store store;
        int currentDay;
      


        public Game()
        {
            player = new Player();
            store = new Store();
            random = new Random();
            player.ChooseName();
            UserInterface.ListInstructions();
            BuildDays();
            PlayGameForWeek();
        }

        public void StartGame()
        {
            PlayGameForWeek();
        }
        public void PlayGameForWeek()
        {
            for (int i = 0; i < 7; i++)
            {
                days[i].RunDay(player, store, day);

                if(i == 7)
                {
                    EndGame();
                }
            }
        }

        public void BuildDays()
        {
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day(player, random);
                days.Add(day);
            }
        }

        public void EndGame()
        {
            Environment.Exit(0);
        }
    }
}
