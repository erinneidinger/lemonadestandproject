using System;
using System.Collections.Generic;

namespace LemonadeStand_3DayStarter
{
    public class Weather
    {
        public string condition;
        public int temperature;
        public List<string> weatherConditions = new List<string>() { "Snowing", "Raining", "Sunny and clear", "Overcast"};
        public string forecast;
        Random rnd = new Random();
        public int todayslow;
        public int todayshigh;
        public int actualtemperature;
        public string actualweather;

        public Weather()
        {
            RandomizeCondition();
            RandomizeTemperature();
            DetermineActualWeather();
        }

        private string RandomizeCondition()
        {
            List<string> weatherConditions = new List<string>() { "Snowing", "Raining", "Sunny and clear", "Overcast" };
            condition = weatherConditions[rnd.Next(weatherConditions.Count)];

            return condition;
        }
        private string RandomizeTemperature()
        
        {
            switch (condition)
            {
                case "Snowing":
                    temperature = rnd.Next(30, 32);
                    forecast = (weatherConditions[0] + " and " + temperature);
                    break;
                case "Raining":
                    temperature = rnd.Next(45, 100);
                    forecast = (weatherConditions[1] + " and " + temperature);
                    break;
                case "Sunny and clear":
                    temperature = rnd.Next(55, 105);
                    forecast = (weatherConditions[2] + " and " + temperature);
                    break;
                case "Overcast":
                    temperature = rnd.Next(50, 90);
                    forecast = (weatherConditions[3] + " and " + temperature);
                    break;
                default:
                    RandomizeCondition();
                    break;
            }
            return forecast;
        }
        public string DetermineActualWeather()
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
