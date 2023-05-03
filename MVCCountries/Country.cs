using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    public enum Continent
    {
        Asia, 
        Africa, 
        NorthAmerica, 
        SouthAmerica, 
        Antarctica, 
        Europe, 
        Australia
    }
    public class Country
    {
        public string Name { get; set; }
        public Continent Continent { get; set; }

        public List<string> Colors = new List<string>();

        public Country(string name,Continent continent,List<string> colors)
        {
         Name = name;
         Continent = continent;
         Colors = colors;

        }


    }
}
