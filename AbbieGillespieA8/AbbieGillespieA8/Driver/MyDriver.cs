using AbbieGillespieA8.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbieGillespieA8.Linq;

namespace AbbieGillespieA8.Driver
{
    public class MyDriver
    {
        LinqController controller = new LinqController();

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

        public void LongerThanFive()
        {
            Console.WriteLine("Houses on the market longer than 5 months:");
            controller.GetHousesOnLongerThanFiveMonths();
            Console.WriteLine(Environment.NewLine);
        }

        public void GoodPrice()
        {
            Console.WriteLine("Houses on the market longer than 5 months that are less than $175,000:");
            controller.GetLowPriceHousesOnLongerThanFiveMonths();
            Console.WriteLine(Environment.NewLine);
        }

        public void ThreeStates()
        {
            Console.WriteLine("Houses in GA, NY, and TX that are more than $140,000:");
            controller.GetHousesInThreeStates();
            Console.WriteLine(Environment.NewLine);
        }

        public void HouseZipCodes()
        {
            Console.WriteLine("Houses that are more than $140,000:");
            controller.GetAllHousesMoreThanOneForty();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
