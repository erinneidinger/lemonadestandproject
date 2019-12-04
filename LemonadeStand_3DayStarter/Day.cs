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
        public double profit;
        public int totalcustomers;
        public int totalpeopleseen;
        public double currentbalancetotal;
        public double wholePrice;

        public Day(Player player, Random random)
        {
            weather = new Weather(random);
            customer = new Customer();
            cupsLeftInPitcher = 12;
        }

        public void RunDay(Player player, Store store, Day day)
        {
            store.GoToStore(player);
            player.wallet.DisplayBalance();
            weather.DisplayForecast();
            player.recipe.AddToRecipe(player.inventory);
            player.recipe.DeterminePricePerCup();
            wholePrice = player.recipe.pricePerCup;
            player.pitcher.FillPitcher(player);
            weather.DisplayActualWeather();
            DetermineCustomers(player, weather, store, day);
            player.pitcher.DisplayLeftoverInventory(player.inventory);
            PostResults(player);
        }

        public void PostResults(Player player)
        {
            DisplayHowManyCustomers();
            DisplayProfit(player.recipe);
            AddProfitToWallet(player.wallet);
            DisplayCurrentTotal();
        }

        public int DetermineCustomers(Player player, Weather weather, Store store, Day day)
        {
            if (weather.actualtemperature > 0 && weather.actualtemperature <= 32)
            {
                while (totalpeopleseen < rnd.Next(40, 60))
                {
                    if (rnd.Next(0, 100) < 30)
                    {
                        if (.03 < wholePrice && wholePrice < .10)
                        {
                            BuyLemonade(player, store, day);
                        }
                    }
                    else
                    {
                        totalpeopleseen += 1;
                    }
                }
            }
            else if (weather.actualtemperature >= 33 && weather.actualtemperature <= 60)
            {
                while (totalpeopleseen < rnd.Next(60, 80))
                {
                    if (rnd.Next(0, 100) < 50)
                    {
                        if (.9 < wholePrice && wholePrice < .18)
                        {
                            BuyLemonade(player, store, day);
                        }
                    }
                    else
                    {
                        totalpeopleseen += 1;
                    }
                }
            }
            else if (weather.actualtemperature > 60 && weather.actualtemperature <= 80)
            {
                while (totalpeopleseen < rnd.Next(90, 110))
                {
                    if (rnd.Next(0, 100) < 60)
                    {
                        if (.17 < wholePrice && wholePrice < .23)
                        {
                            BuyLemonade(player, store, day);
                        }
                    }
                    else
                    {
                        totalpeopleseen += 1;
                    }
                }
            }
            else if (weather.actualtemperature > 80 && weather.actualtemperature <= 97)
            {

                while (totalpeopleseen < rnd.Next(110, 150))
                {
                    if (rnd.Next(0, 100) < 75)
                    {
                        if (.22 < wholePrice && wholePrice < .29)
                        {
                            BuyLemonade(player, store, day);
                        }
                    }
                    else
                    {
                        totalpeopleseen += 1;
                    }
                }
            }
            else if (weather.actualtemperature > 97 && weather.actualtemperature <= 130)
            {

                while (totalpeopleseen < rnd.Next(140, 200))
                {
                    if (rnd.Next(0, 100) < 85)
                    {
                        if (.28 < wholePrice && wholePrice < .36)
                        {
                            BuyLemonade(player, store, day);
                        }
                    }
                    else
                    {
                        totalpeopleseen += 1;
                    }
                }
            }
            return totalpeopleseen;
        }
        public void BuyLemonade(Player player, Store store, Day day)
        {
            if (cupsLeftInPitcher == 0)
            {
                player.pitcher.RefillPitcher(player.inventory, player.recipe, store, player, day);
            }
            else if (player.inventory.cups.Count == 0)
            {
            }
            else
            {
                player.inventory.cups.RemoveAt(0);
                totalcustomers += 1;
                totalpeopleseen += 1;
            }
        }

        public void DisplayHowManyCustomers()
        {
            Console.WriteLine("Total people seen today: " + totalpeopleseen);
            Console.WriteLine("Total customers: " + totalcustomers);
            Console.WriteLine(totalcustomers + " out of " + totalpeopleseen + " bought lemonade.");
        }

        public void DisplayProfit(Recipe recipe)
        {
            profit = totalcustomers * recipe.pricePerCup;
            Console.WriteLine("The profit from today's sale is $" + profit + "!");
        }
        public void AddProfitToWallet(Wallet wallet)
        {
            currentbalancetotal = wallet.Money + profit;
        }

        public void DisplayCurrentTotal()
        {
            Console.WriteLine("You currently have $" + currentbalancetotal + " in your wallet.");
        }
    }
}
