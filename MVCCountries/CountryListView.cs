﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    public class CountryListView
    {
        public List<Country> Countries;
        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }

        public void Display()
        {
         for(int i=0; i<Countries.Count; i++)
            {
                Console.WriteLine(i + ": " + Countries[i].Name);
            }
        }



    }
}
