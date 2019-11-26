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
        int percentageBuyingLemonade;

        public Customer()
        {
        
        }
        public void BuyingLemonade(Weather weather)
        {
            if(weather.temperature <= 32)
            { 
                
            }
            else if(weather.temperature >= 40 && weather.temperature <= 60)
            {
                
            }
            else if(weather.temperature > 60 && weather.temperature <= 80)
            {

            }
            else if(weather.temperature > 80 && weather.temperature <= 97)
            {

            }
            else
            {

            }
        }
    }
}
