using AbbieGillespieA8.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbieGillespieA8.Linq;

namespace AbbieGillespieA8.Driver
{
    /// <summary>
    /// The driver for the program.
    /// </summary>
    public class MyDriver
    {
        LinqController controller = new LinqController();

        /// <summary>
        /// Prints out the whole list of the json file data.
        /// </summary>
        public void Run()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            foreach (var house in houses)
            {
                Console.WriteLine(house);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Calls the method of getting the house that has been on the market for longer than five months.
        /// </summary>
        public void LongerThanFive()
        {
            Console.WriteLine("Houses on the market longer than 5 months:");
            controller.GetHousesOnLongerThanFiveMonths();
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Calls the method of getting the houses that have been on the market for longer than five months.
        /// </summary>
        public void LamMoreThanFive()
        {
            Console.WriteLine("Houses on the market longer than 5 months:");
            controller.GetHouseOnMoreThanFiveMonths();
            Console.WriteLine(Environment.NewLine) ;
        }

        /// <summary>
        /// Calls the method of getting the houses that have been on the market for longer than five months
        /// and cost less than 175 thousand dollars.
        /// </summary>
        public void GoodPrice()
        {
            Console.WriteLine("Houses on the market longer than 5 months that are less than $175,000:");
            controller.GetLowPriceHousesOnLongerThanFiveMonths();
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Calls the method of getting the houses that have been on the market for longer than five months
        /// and cost less than 175 thousand dollars.
        /// </summary>
        public void GoodPriceLam()
        {
            Console.WriteLine("Houses on the market longer than 5 months that are less than $175,000:");
            controller.GetGoodHousePriceLam();
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Calls the method of getting the houses that are in GA, NY, and TX that cost more than 140 thousand dollars.
        /// </summary>
        public void ThreeStates()
        {
            Console.WriteLine("Houses in GA, NY, and TX that are more than $140,000:");
            controller.GetHousesInThreeStates();
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Calls the method of getting the houses that are in GA, NY, and TX that cost more than 140 thousand dollars.
        /// </summary>
        public void ThreeStatesLam()
        {
            Console.WriteLine("Houses in GA, NY, and TX that are more than $140,000:");
            controller.GetHousesInThreeStatesLam();
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Calls the method of getting the houses that cost more than 140 thousand dollars.
        /// </summary>
        public void HouseZipCodes()
        {
            Console.WriteLine("Houses that are more than $140,000:");
            controller.GetAllHousesMoreThanOneForty();
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Calls the method of getting the houses that cost more than 140 thousand dollars.
        /// </summary>
        public void HouseZipCodesLam()
        {
            Console.WriteLine("Houses that are more than $140,000:");
            controller.GetAllHousesMoreThanOneFortyLam();
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Calls the method of getting the houses in GA, NY, and TX.
        /// </summary>
        public void HousesByState()
        {
            controller.GetHousesOrderedByState();
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Calls the method of getting the houses in GA, NY, and TX.
        /// </summary>
        public void HousesByStateLam()
        {
            controller.GetHousesOrderedByStateLam();
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Calls the method of getting the houses that have been on the market less than six months and cost more than 
        /// 250 thousand dollars.
        /// </summary>
        public void HouseUnderFourMonths()
        {
            controller.GetHouseOnLessThanFourMonths();
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Calls the method of getting the houses that have been on the market less than six months and cost more than 
        /// 250 thousand dollars.
        /// </summary>
        public void HouseUnderFourMonthsLam()
        {
            controller.GetHouseOnLessThanFourMonthsLam();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
