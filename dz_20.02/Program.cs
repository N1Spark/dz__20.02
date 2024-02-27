using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_20._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>
            {
                new Country { Name = "Ukraine", Capital = "Kiyv", Population = 33000000, Area = 603628, Continent = "Europe" },
                new Country { Name = "France", Capital = "Paris", Population = 67000000, Area = 551000, Continent = "Europe" },
                new Country { Name = "USA", Capital = "Washington, D.C.", Population = 328239523, Area = 9833517, Continent = "North America" },
                new Country { Name = "India", Capital = "New Delhi", Population = 1300000000, Area = 3300000, Continent = "Asia" },
                new Country { Name = "Argentina", Capital = "Buenos Aires", Population = 45000000, Area = 2800000, Continent = "South America" },
                new Country { Name = "Nigeria", Capital = "Abuja", Population = 200962417, Area = 923768, Continent = "Africa" },
                new Country { Name = "Japan", Capital = "Tokio", Population = 126000000, Area = 378000, Continent = "Asia" },
                new Country { Name = "Germany", Capital = "Berlin", Population = 83000000, Area = 357000, Continent = "Europe" },
                new Country { Name = "Italy", Capital = "Rome", Population = 60000000, Area = 301000, Continent = "Europe" },
                new Country { Name = "Canada", Capital = "Ottawa", Population = 38000000, Area = 10000000, Continent = "North America" }
            };

            #region Зад1
            Console.WriteLine("Зад 1");
            var linq_request = from i in countries select i;
            foreach (var i in linq_request)
            {
                Console.Write(i);
            }
            Console.WriteLine('\n');

            foreach (var i in linq_request)
            {
                Console.Write(i.Name + '\n');
            }
            Console.WriteLine('\n');

            foreach (var i in linq_request)
            {
                Console.Write(i.Capital + '\n');
            }
            Console.WriteLine('\n');

            linq_request = from i in countries where i.Continent == "Europe" select i ;
            foreach (var i in linq_request)
            {
                Console.Write(i.Name + '\n');
            }
            Console.WriteLine('\n');

            Console.Write("Введите площадь страны: ");
            int area_zone = Convert.ToInt32(Console.ReadLine());
            linq_request = from i in countries where i.Area > area_zone select i;
            foreach (var i in linq_request)
            {
                Console.Write(i.Name + '\n');
            }
            Console.WriteLine('\n');
            #endregion


            #region Зад2
            Console.WriteLine("Зад 2");
            linq_request = from i in countries where i.Name.Contains('a') && i.Name.Contains('u') select i;
            foreach (var i in linq_request)
            {
                Console.Write(i.Name + '\n');
            }
            Console.WriteLine('\n');

            linq_request = from i in countries where i.Name.StartsWith("A") select i;
            foreach (var i in linq_request)
            {
                Console.Write(i.Name + '\n');
            }
            Console.WriteLine('\n');

            Console.Write("Введите min площадь страны: ");
            int area_zone_min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите max площадь страны: ");
            int area_zone_max = Convert.ToInt32(Console.ReadLine());
            linq_request = from i in countries where i.Area > area_zone_min && i.Area < area_zone_max select i;
            foreach (var i in linq_request)
            {
                Console.Write(i.Name + '\n');
            }
            Console.WriteLine('\n');

            Console.Write("Введите населенность страны: ");
            int population_zone = Convert.ToInt32(Console.ReadLine());
            linq_request = from i in countries where i.Population > population_zone select i;
            foreach (var i in linq_request)
            {
                Console.Write(i.Name + '\n');
            }
            Console.WriteLine('\n');
            #endregion



            #region Зад3
            Console.WriteLine("Зад 3");
            linq_request = (from i in countries orderby i.Area descending select i).Take(5);
            foreach (var i in linq_request)
            {
                Console.Write(i.Name + '\n');
            }
            Console.WriteLine('\n');

            linq_request = (from i in countries orderby i.Population descending select i).Take(5);
            foreach (var i in linq_request)
            {
                Console.Write(i.Name + '\n');
            }
            Console.WriteLine('\n');

            linq_request = (from i in countries orderby i.Area descending select i).Take(1);
            foreach (var i in linq_request)
            {
                Console.Write(i.Name + '\n');
            }
            Console.WriteLine('\n');

            linq_request = (from i in countries orderby i.Population descending select i).Take(1);
            foreach (var i in linq_request)
            {
                Console.Write(i.Name + '\n');
            }
            Console.WriteLine('\n');

            linq_request = (from i in countries where i.Continent == "Europe" orderby i.Area select i).Take(1);
            foreach (var i in linq_request)
            {
                Console.Write(i.Name + '\n');
            }
            Console.WriteLine('\n');

            var averageArea = (from i in countries where i.Continent == "Asia" select i.Area).Average();
            Console.WriteLine($"Cредняя площадь стран в Азии: {averageArea} km^2");
            #endregion
        }
    }
}
