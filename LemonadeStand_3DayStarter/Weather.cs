using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        public string condition;
        public int temperature;
        public List<string> weatherConditions = new List<string>() { "Snowing", "Raining", "Sunny and clear", "Overcast"};
        Random rnd = new Random();
       
        public Weather()
        {
            RandomizeCondition();
            RandomizeTemperature();
        }

        private void RandomizeCondition()
        {
            List<string> weatherConditions = new List<string>() { "" };
            condition = weatherConditions[rnd.Next(weatherConditions.Count)];
        }
        private void RandomizeTemperature()
        {
            Console.WriteLine();
            string condition = Console.ReadLine();
            switch(condition)
            {
                case "Snowing":
                    temperature = rnd.Next(0, 32);
                    Console.WriteLine(temperature);
                    break;
                case "Raining":
                    temperature = rnd.Next(40, 100);
                    Console.WriteLine(temperature);
                    break;
                case "Sunny and clear":
                    temperature = rnd.Next(55, 110);
                    Console.WriteLine(temperature);
                    break;
                case "Overcast":
                    temperature = rnd.Next(45, 90);
                    Console.WriteLine(temperature);
                    break;
            }
        }
        
    }
}
