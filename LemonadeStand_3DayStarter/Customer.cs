using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        List<string> Names = new List<string>() { "Jess", "Nick", "Cece", "Winston", "Schmidt" };
        string name;
        Random rnd = new Random();


        public Customer()
        {
            
        }
        public void DetermineCustomers (Weather weather)
        {
            if(weather.temperature <= 32)
            {
                if (rnd.Next(0, 100) < 30)
                {
                   
                    //subtract cup and pay price per cup
                }
                else
                {
                    //pass by
                }
            }
            else if(weather.temperature >= 40 && weather.temperature <= 60)
            {
                if (rnd.Next(0, 100) < 50)
                {
                    //subtract cup and pay price per cup
                }
                else
                {
                    //pass by
                }
            }
            else if(weather.temperature > 60 && weather.temperature <= 80)
            {
                if (rnd.Next(0, 100) < 60)
                {
                   //subtract cup and pay price per cup
                }
                else
                {
                    //pass by
                }
            }
            else if(weather.temperature > 80 && weather.temperature <= 97)
            {
                if (rnd.Next(0, 100) < 75)
                {
                    //subtract cup and pay price per cup
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
                    //subtract cup and pay price per cup
                }
                else
                {
                    //pass by
                }
            }
        }

        public void IdealCustomerPrice()
        {

        }
    }
}
