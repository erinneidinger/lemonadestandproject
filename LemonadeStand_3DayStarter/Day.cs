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
        Random rnd = new Random();
        public int cup;

        public Day()
        {
            weather = new Weather();
            Customer customer = new Customer();
            DetermineCustomers();
            SubtractCup();
            AddProfitToWallet();
        }

        public void DetermineCustomers()
        {

            //how many customers buy based on weather
        }
        public void SubtractCup()
        {

        }
        public void AddProfitToWallet()
        {

        }
        
    }
}
