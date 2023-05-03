using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    public class CountryView
    {

      
        public Country DisplayCountry;
        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }
        public void Display()
        {
            CountryView countryView = new CountryView(DisplayCountry);
            
            Console.WriteLine("Name: " + DisplayCountry.Name);
            Console.WriteLine("Continent: " + DisplayCountry.Continent);
            Console.WriteLine("Color: " + countryView.DisplayColors());
        }

        public string DisplayColors()
        {
            string s = "";
            for(int i = 0; i < DisplayCountry.Colors.Count; i++)
            {
                s +=" "+ DisplayCountry.Colors[i];
               
            }
            return s;
        }


    }
}
    

