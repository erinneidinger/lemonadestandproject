﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        public Recipe()
        {
        }
        public void AddingAmountOfLemons()
        {
            Console.WriteLine("How many lemons would you like to add to your recipe?");
            amountOfLemons = Console.ReadLine();
            //Inventory.lemons.Count -= amountOfLemons();
        }
        public void AddingAmountOfSugarCubes()
        {
            Console.WriteLine("How many sugar cubes would you like to add to your recipe?");
            amountOfSugarCubes = Console.ReadLine();
        }
        public void AddingAmountOfIceCubes()
        {
            Console.WriteLine("How many ice cubes would you like to add to your recipe?");
            amountOfIceCubes = Console.ReadLine();
        }
        public void DeterminePricePerCup()
        {
            Console.WriteLine("Please write the price per cup:");
            pricePerCup = Console.ReadLine();
        }
    }
}
