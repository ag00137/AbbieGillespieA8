using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AbbieGillespieA8.Data;

namespace AbbieGillespieA8.Linq
{
    /// <summary>
    /// Class that holds the methods searching through the json file data.
    /// </summary>
    public class LinqController
    {       
        /// <summary>
        /// Initializes the LinqController constructor.
        /// </summary>
        public LinqController()
        {
           
        }

        /// <summary>
        /// Searches through the data for houses that have been on the market for longer than five months then writes them out.
        /// </summary>
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

        /// <summary>
        /// Searches through the data for houses that have been on the market for longer than five months then writes them out.
        /// </summary>
        public void GetHouseOnMoreThanFiveMonths()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            var longerThanFive = houses.Where(house => house.TimeOnMarket > 5);

            foreach (var house in longerThanFive)
            {
                Console.WriteLine(house);
            }

        }

        /// <summary>
        /// Searches for houses that have been on the market for longer than five months and are less than 175 thousand dollars
        /// then writes them out.
        /// </summary>
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

        /// <summary>
        /// Searches for houses that have been on the market for longer than five months and are less than 175 thousand dollars
        /// then writes them out.
        /// </summary>
        public void GetGoodHousePriceLam()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            var goodPrice = houses.Where(house => house.TimeOnMarket > 5 && house.Price < 175000);

            foreach (var house in goodPrice)
            {
                Console.WriteLine(house);
            }
        }

        /// <summary>
        /// Searches for houses that are within GA, NY, and TX that cost more than 140 thousand dollars then writes them out in 
        /// order of their price.
        /// </summary>
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

        /// <summary>
        /// Searches for houses that are within GA, NY, and TX that cost more than 140 thousand dollars then writes them out in 
        /// order of their price.
        /// </summary>
        public void GetHousesInThreeStatesLam()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            var threeStates = houses
                              .Where(house => house.Price > 140000 && house.State == "GA" || house.State == "NY" || house.State == "TX")
                              .OrderBy(house => house.Price);

            foreach (var house in threeStates)
            {
                Console.WriteLine(house);
            }
        }

        /// <summary>
        /// Searches for houses that cost more than 140 thousand dollars and writes them out in descending order by their zip codes.
        /// </summary>
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

        /// <summary>
        /// Searches for houses that cost more than 140 thousand dollars and writes them out in descending order by their zip codes.
        /// </summary>
        public void GetAllHousesMoreThanOneFortyLam()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            var zipCodes = houses
                           .Where(house => house.Price > 140000)
                           .OrderByDescending(house => house.ZipCode);


            foreach (var house in zipCodes)
            {
                Console.WriteLine(house);
            }
        }

        /// <summary>
        /// Searches for houses that are from the states GA, NY, and TX then are written out by their state and price in descending
        /// order.
        /// </summary>
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

        /// <summary>
        /// Searches for houses that are from the states GA, NY, and TX then are written out by their state and price in descending
        /// order.
        /// </summary>
        public void GetHousesOrderedByStateLam()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            var states = houses
                         .Where(house => house.State == "GA" || house.State == "NY" || house.State == "TX")
                         .OrderByDescending(house => house.Price)
                         .GroupBy(house => house.State);


            foreach (var group in states)
            {
                Console.WriteLine($"Current State: {group.Key}");

                foreach (var house in group)
                {
                    Console.WriteLine(house);
                }
            }
        }

        /// <summary>
        /// Searches for houses that have been on the market for less than six months and cost more than 250 thousand dollars
        /// then written out by hteir state and are odered by price.
        /// </summary>
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

        /// <summary>
        /// Searches for houses that have been on the market for less than six months and cost more than 250 thousand dollars
        /// then written out by hteir state and are odered by price.
        /// </summary>
        public void GetHouseOnLessThanFourMonthsLam()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            var months = houses
                         .Where(house => house.Price > 250000 && house.TimeOnMarket < 6)
                         .OrderBy(house => house.Price)
                         .GroupBy(house => house.State);

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
