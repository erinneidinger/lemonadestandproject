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
            }
            EndGame();
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
            Console.WriteLine("Nice job operating the lemonade stand for a week.");
            ReturnForNextGame();
        }

        public void ReturnForNextGame()
        {
            Console.WriteLine("Thanks for playing! Press 1 to exit out, press any key to play again.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("You are now exiting the game, goodbye!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Let's Play");
                    StartGame();
                    break;
            }
        }
    }
}
