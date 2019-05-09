using System;
namespace Lab_Countries
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country c)
        {
            DisplayCountry = c;

        }

        public void Display()
        {
            Console.WriteLine(DisplayCountry.Name);
            Console.WriteLine(DisplayCountry.Continent);

            for (int i = 0; i < DisplayCountry.Colors.Count; i++)
            {
                Console.WriteLine(DisplayCountry.Colors[i]);
            }
        }
    }
}
