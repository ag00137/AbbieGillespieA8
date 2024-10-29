using AbbieGillespieA8.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbieGillespieA8.Driver
{
    public class MyDriver
    {
        

        public void Run()
        {
            var dataImporter = new DataImporter();

            List<House> houses = dataImporter.ImportData();

            foreach (var house in houses)
            {
                Console.WriteLine(house);
            }
        }
    }
}
