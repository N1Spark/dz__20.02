using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_20._02
{
    internal class Country
    {

        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
        public string Continent { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Capital: {Capital}, Population: {Population}, Area: {Area}, Continent: {Continent}\n";
        }
    }
}
