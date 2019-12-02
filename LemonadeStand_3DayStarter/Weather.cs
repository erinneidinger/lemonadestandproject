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
           weatherConditions = new List<string>() { "Snowing", "Raining", "Sunny and clear", "Overcast" };
           condition = weatherConditions[rnd.Next(weatherConditions.Count)];

            return condition;
        }
        private string RandomizeTemperature()
        {
            switch (condition)
            {
                case "Snowing":
                    temperature = rnd.Next(31, 32);
                    forecast = (weatherConditions[0] + " and " + temperature);
                    break;
                case "Raining":
                    temperature = rnd.Next(55, 100);
                    forecast = (weatherConditions[1] + " and " + temperature);
                    break;
                case "Sunny and clear":
                    temperature = rnd.Next(65, 110);
                    forecast = (weatherConditions[2] + " and " + temperature);
                    break;
                case "Overcast":
                    temperature = rnd.Next(60, 90);
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
