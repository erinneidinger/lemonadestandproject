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

        public Day()
        {
            weather = new Weather();
            customer = new Customer();
            cupsLeftInPitcher = 12;
        }

        public void SubtractCup()
        {
            
            cupsLeftInPitcher -= 1;
        }
        public void AddProfitToWallet()
        {
            //player.wallet.money += player.recipe.pricePerCup; 
        }
        public void DetermineCustomers(Weather weather)
        {
            if (weather.temperature <= 32)
            {
                if (rnd.Next(0, 100) < 30)
                {

                    SubtractCup();
                    AddProfitToWallet();
                }
                else
                {
                    //pass by
                }
            }
            else if (weather.temperature >= 40 && weather.temperature <= 60)
            {
                if (rnd.Next(0, 100) < 50)
                {
                    SubtractCup();
                    AddProfitToWallet();
                }
                else
                {
                    //pass by
                }
            }
            else if (weather.temperature > 60 && weather.temperature <= 80)
            {
                if (rnd.Next(0, 100) < 60)
                {
                    SubtractCup();
                    AddProfitToWallet();
                }
                else
                {
                    //pass by
                }
            }
            else if (weather.temperature > 80 && weather.temperature <= 97)
            {
                if (rnd.Next(0, 100) < 75)
                {
                    SubtractCup();
                    AddProfitToWallet();
                }
                else
                {
                    //pass by
                }
            }
            else
            {
                if (rnd.Next(0, 100) < 85)
                {
                    SubtractCup();
                    AddProfitToWallet();
                }
                else
                {
                    //pass by
                }
            }
        }
        
    }
}
