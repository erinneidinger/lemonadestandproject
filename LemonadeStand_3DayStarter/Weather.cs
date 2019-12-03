using System;
using System.Collections.Generic;

namespace LemonadeStand_3DayStarter
{
    public class Weather
    {
        public string condition;
        public int temperature;
        public List<string> weatherConditions;
        public string forecast;
        public int todayslow;
        public int todayshigh;
        public int actualtemperature;
        public string actualweather;

        public Weather(Random random)
        {
            RandomizeCondition(random);
            RandomizeTemperature(random);
            DetermineActualWeather(random);
        }

        public string RandomizeCondition(Random rnd)
        {
           weatherConditions = new List<string>() { "Snowing", "Raining", "Sunny and clear", "Overcast" };
           condition = weatherConditions[rnd.Next(weatherConditions.Count)];

            return condition;
        }
        private string RandomizeTemperature(Random rnd)
        {
            switch (condition)
            {
                case "Snowing":
                    temperature = rnd.Next(31, 32);
                    forecast = (condition + " and " + temperature);
                    break;
                case "Raining":
                    temperature = rnd.Next(55, 100);
                    forecast = (condition + " and " + temperature);
                    break;
                case "Sunny and clear":
                    temperature = rnd.Next(65, 110);
                    forecast = (condition + " and " + temperature);
                    break;
                case "Overcast":
                    temperature = rnd.Next(60, 90);
                    forecast = (condition + " and " + temperature);
                    break;
                default:
                    RandomizeCondition(rnd);
                    break;
            }
            return forecast;
        }
        public string DetermineActualWeather(Random rnd)
        {
            todayslow = (temperature - 10);
            todayshigh = (temperature + 10);
            actualtemperature = rnd.Next(todayslow, todayshigh);
            actualweather = (condition + " and " + actualtemperature);
            return actualweather;
        }
        public void DisplayForecast()
        {
           
            Console.WriteLine("Tomorrow's forecast is: " + forecast);
        }
        public void DisplayActualWeather()
        {
            
            Console.WriteLine("Today's actual weather is: " + actualweather);
        }

    }
}
