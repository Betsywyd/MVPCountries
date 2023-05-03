using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; }=new List<Country>();
        public CountryController() 
        {
            CountryDb.Add(new Country("USA", Continent.NorthAmerica, new List<string>() { "Red", "White", "Blue" }));
            CountryDb.Add(new Country("Canada", Continent.NorthAmerica, new List<string>() { "Red", "White"}));
            CountryDb.Add(new Country("Germany", Continent.Europe, new List<string>() { "Red", "Black", "Gold" }));
        }

        public void CountryAction(Country c)
        {
            CountryView cv=new CountryView(c);
            cv.Display();

        }
        public void WelcomeAction()
        {
            CountryListView clv =new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app.Please select a country from the following list:");
            clv.Display();
          
            int pick = int.Parse(Console.ReadLine());
            CountryView cv=new CountryView(CountryDb[pick]);
            cv.Display();
            Console.WriteLine("Would you like to select another country? y/n");
            string response = Console.ReadLine();

            if (response == "y")
            {
                WelcomeAction();
            }
            else
            {
                Console.WriteLine("Okay good bye!");
            }

        }
    }
}
