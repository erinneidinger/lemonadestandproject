using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        public Weather weather;
        public List<Customer> customers;
        public Customer customer;
        Random rnd = new Random();
        public int cupsLeftInPitcher;
        public int cup;
        public double profit;
        public int totalcustomers;
        public int totalpeopleseen;

        public Day(Player player)
        {
            weather = new Weather();
            customer = new Customer();
            cupsLeftInPitcher = 12;
            DetermineCustomers(player);
        }
        public void RunDay(Player player, Store store)
        {
           
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
            player.wallet.DisplayBalance(player.wallet.Money);
            weather.DisplayForecast();
            player.recipe.AddingAmountOfLemons(player.inventory);
            player.recipe.AddingAmountOfSugarCubes(player.inventory);
            player.recipe.AddingAmountOfIceCubes(player.inventory);
            player.recipe.DeterminePricePerCup();
            player.pitcher.FillPitcher(player.inventory, player.recipe);
            player.pitcher.DisplayLeftoverInventory(player.inventory);
            weather.DisplayActualWeather(); //where game ends. 
            DisplayHowManyCustomers();
            DisplayProfit();
        }
        public void SubtractCup()
        {
            cupsLeftInPitcher -= 1;
        }
        public int DetermineCustomers(Player player)
        {
            if (weather.actualtemperature <= 32)
            {

                while (totalpeopleseen < 50)
                {
                    if (rnd.Next(0, 100) < 30)
                    {
                        if (3 < player.recipe.pricePerCup || player.recipe.pricePerCup < 10)
                        {
                            AddProfitToWallet();
                            totalcustomers += 1;
                            totalpeopleseen += 1;
                        }
                    }
                    else
                    {
                        totalpeopleseen += 1;
                    }
                }
                return totalpeopleseen;
            }
            else if (weather.actualtemperature >= 40 && weather.actualtemperature <= 60)
            {
                while (totalpeopleseen < 70)
                {
                    if (rnd.Next(0, 100) < 50)
                    {
                        if (9 < player.recipe.pricePerCup || player.recipe.pricePerCup < 18)
                        {
                            AddProfitToWallet();
                            totalcustomers += 1;
                            totalpeopleseen += 1;
                        }
                    }
                    else
                    {
                        totalpeopleseen += 1;
                    }
                }
                return totalpeopleseen;
            }
            else if (weather.actualtemperature > 60 && weather.actualtemperature <= 80)
            {
                while (totalpeopleseen < 100)
                {
                    if (rnd.Next(0, 100) < 60)
                    {
                        if (17 < player.recipe.pricePerCup || player.recipe.pricePerCup < 23)
                        {
                            AddProfitToWallet();
                            totalcustomers += 1;
                            totalpeopleseen += 1;
                        }
                    }
                    else
                    {
                        totalpeopleseen += 1;
                    }
                }

                return totalpeopleseen;
            }
            else if (weather.actualtemperature > 80 && weather.actualtemperature <= 97)
            {

            while (totalpeopleseen < 120)
                {
                    if (rnd.Next(0, 100) < 75)
                    {
                        if (22 < player.recipe.pricePerCup || player.recipe.pricePerCup < 29)
                        {
                            AddProfitToWallet();
                            totalcustomers += 1;
                        }
                       
                    }
                    else
                    {
                        totalpeopleseen += 1;
                    }
                }

                return totalpeopleseen;
            }
            else
            {

            while(totalpeopleseen < 150)
                {
                    if (rnd.Next(0, 100) < 85)
                    {
                        if (28 < player.recipe.pricePerCup || player.recipe.pricePerCup < 36)
                        {
                            AddProfitToWallet();
                            totalcustomers += 1;
                        }
                        
                    }
                    else
                    {
                        totalpeopleseen += 1;
                    }
                }

                return totalpeopleseen; 
            }
        }

        public void DisplayHowManyCustomers()
        {
            Console.WriteLine("Total people seen today: " + totalpeopleseen);
            Console.WriteLine("Total customers: " + totalcustomers);
            Console.WriteLine(totalcustomers + " out of " + totalpeopleseen + " bought lemonade.");
        }
        public void AddProfitToWallet()
        {
            SubtractCup();
            //wallet.money += profit; 
        }
        public void DisplayProfit()
        {
            //profit += player.recipe.pricePerCup;
        }

    }
}
