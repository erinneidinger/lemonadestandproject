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
        public double currentbalancetotal;
        public double wholePrice;

        public Day(Player player)
        {
            weather = new Weather();
            customer = new Customer();
            cupsLeftInPitcher = 12;
           
            
        }
        public void RunDay(Player player, Store store)
        {
           
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
            player.wallet.DisplayBalance();
            weather.DisplayForecast();
            player.recipe.AddingAmountOfLemons(player.inventory);
            player.recipe.AddingAmountOfSugarCubes(player.inventory);
            player.recipe.AddingAmountOfIceCubes(player.inventory);
            player.recipe.DeterminePricePerCup();
            player.pitcher.FillPitcher(player.inventory, player.recipe);
            player.pitcher.DisplayLeftoverInventory(player.inventory);
            weather.DisplayActualWeather();
            DetermineCustomers(player);
            DisplayHowManyCustomers();
            DisplayProfit(player.recipe);
            AddProfitToWallet(player.wallet);
            DisplayCurrentTotal();
        }
        public void SubtractCup()
        {
            cupsLeftInPitcher -= 1;
        }


        public int DetermineCustomers(Player player)
        {

            wholePrice = Convert.ToInt32(player.recipe.pricePerCup);
            if (weather.actualtemperature <= 32)
            {

                while (totalpeopleseen < 50)
                {
                    if (rnd.Next(0, 100) < 30)
                    {
                        if (3 < wholePrice || wholePrice < 10)
                        {
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
                        if (9 < wholePrice || wholePrice < 18)
                        {
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
                        if (17 < wholePrice || wholePrice < 23)
                        {
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
                        if (22 < wholePrice || wholePrice < 29)
                        {
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
            else
            {

            while(totalpeopleseen < 150)
                {
                    if (rnd.Next(0, 100) < 85)
                    {
                        if (28 < wholePrice || wholePrice < 36)
                        {
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
            Console.WriteLine("The profit from today's sale is " + profit + "!");
        }
        public void AddProfitToWallet(Wallet wallet)
        {
           currentbalancetotal = wallet.Money + profit;
        }

        public void DisplayCurrentTotal()
        {
            Console.WriteLine("You currently have " + currentbalancetotal + " in your wallet.");
        }

    }
}
