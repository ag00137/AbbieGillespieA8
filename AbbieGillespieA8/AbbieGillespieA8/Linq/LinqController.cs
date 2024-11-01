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

        public void GetHousesInThreeStates()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            var threeStates = from house in houses
                              where house.Price > 140000 && house.State == "GA" || house.State == "NY" || house.State == "TX"
                              orderby house.Price 
                              select house;

            foreach (var house in threeStates)
            {
                Console.WriteLine(house);
            }
        }

        public void GetAllHousesMoreThanOneForty()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            var zipCodes = from house in houses
                           where house.Price > 140000
                           orderby house.ZipCode descending
                           select house;

            foreach (var house in zipCodes)
            {
                Console.WriteLine(house);
            }
        }

        public void GetHousesOrderedByState()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            var states = from house in houses
                         where house.State == "GA" || house.State == "NY" || house.State == "TX"
                         orderby house.Price descending
                         group house by house.State into stateGroup
                         select stateGroup;

            foreach (var group in states)
            {
                Console.WriteLine($"Current State: {group.Key}");

                foreach (var house in group)
                {
                    Console.WriteLine(house);
                }
            }                        
        }

        public void GetHouseOnLessThanFourMonths()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            var months = from house in houses
                         where house.Price > 250000 && house.TimeOnMarket < 6
                         orderby house.Price
                         group house by house.State into stateGroup
                         select stateGroup;

            foreach (var group in months)
            {
                Console.WriteLine($"Current State: {group.Key}");
                foreach (var house in group)
                {
                    Console.WriteLine(house);
                }
            }                        
        }
        }
    }
