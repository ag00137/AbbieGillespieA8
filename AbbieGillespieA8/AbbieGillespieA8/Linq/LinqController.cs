using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbieGillespieA8.Data;

namespace AbbieGillespieA8.Linq
{
    public class LinqController
    {
        

        public LinqController()
        {
           
        }

        public void GetHousesOnLongerThanFiveMonths()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            var longerThanFiveQuery = from house in houses
                                      where house.TimeOnMarket > 5
                                      select house;

            foreach (var house in longerThanFiveQuery)
            {
                Console.WriteLine(house);
            }
        }

        public void GetLowPriceHousesOnLongerThanFiveMonths()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            var goodPrice = from house in houses
                            where house.TimeOnMarket > 5 && house.Price < 175000
                            select house;
            foreach (var house in goodPrice)
            {
                Console.WriteLine(house);
            }
        }
    }
}
