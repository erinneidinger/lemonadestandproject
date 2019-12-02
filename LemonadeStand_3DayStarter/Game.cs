﻿using System;
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
        Day day = new Day();
        int currentDay;

        public Game()
        {
           player = new Player();
           store = new Store();
           
        }
        public void ListInstructions()
        {

        }

        public void StartGame()
        {
            player.ChooseName();
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
            player.wallet.DisplayBalance(player.wallet.Money);
            day.weather.DisplayForecast();
            player.recipe.AddingAmountOfLemons(player.inventory);
            player.recipe.AddingAmountOfSugarCubes(player.inventory);
            player.recipe.AddingAmountOfIceCubes(player.inventory);
            player.recipe.DeterminePricePerCup();
            player.pitcher.FillPitcher(player.inventory, player.recipe);
            player.pitcher.DisplayLeftoverInventory(player.inventory);
            day.weather.DisplayActualWeather();
          
            Console.ReadLine();
            //program works, keep adding functions
        }
        public void PlayGameForWeek()
        {
            for (int i = 0; i < 7; i++)
            {

            }
        }
    }
}
