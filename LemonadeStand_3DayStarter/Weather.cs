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
        }

        private void RandomizeCondition()
        {
            List<string> weatherConditions = new List<string>() { "Snowing", "Raining", "Sunny and clear", "Overcast" };
            condition = weatherConditions[rnd.Next(weatherConditions.Count)];
        }
        private string RandomizeTemperature()
        
        {
            Console.WriteLine();
            switch (condition)
            {
                case "Snowing":
                    temperature = rnd.Next(0, 32);
                    forecast = (weatherConditions[0] + " and " + temperature);
                    Console.WriteLine(forecast);
                    break;
                case "Raining":
                    temperature = rnd.Next(45, 100);
                    forecast = (weatherConditions[1] + " and " + temperature);
                    Console.WriteLine(forecast);
                    break;
                case "Sunny and clear":
                    temperature = rnd.Next(55, 110);
                    forecast = (weatherConditions[2] + " and " + temperature);
                    Console.WriteLine(forecast);
                    break;
                case "Overcast":
                    temperature = rnd.Next(50, 90);
                    forecast = (weatherConditions[3] + " and " + temperature);
                    Console.WriteLine(forecast);
                    break;
                default:
                    RandomizeTemperature();
                    //figure out why temperature is not listed.
                    break;
            }
            return forecast;
        }
        public string DetermineActualWeather()
        {
            todayslow = temperature - 10;
            todayshigh = temperature + 10;
            actualtemperature = rnd.Next(todayslow, todayshigh);
            actualweather = (temperature + " and " + weatherConditions);
            return actualweather;
        }
        public void DisplayForecast()
        {
            Console.WriteLine(forecast);
        }
        public void DisplayActualWeather()
        {
            Console.WriteLine(actualweather);
        }

    }
}
