using System;

namespace Lab_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country();

            country.Name = "Canada";
            country.Continent = "North America";

            country.Colors[0] = "Red";
            country.Colors[1] = "White";



            CountryView(country)
        }
    }
}
