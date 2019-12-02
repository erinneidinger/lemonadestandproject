using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Wallet
    {
        private double money;

        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                money = 20.00;
            }
        }

        public Wallet()
        {
            money = 20.00;
        }

        public double PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
            return money;
        }
        public void DisplayBalance()
        {
            Console.WriteLine("Your current balence is " + money + ".");
        }
    }
}
