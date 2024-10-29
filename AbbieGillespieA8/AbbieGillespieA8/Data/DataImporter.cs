using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Runtime.ConstrainedExecution;

namespace AbbieGillespieA8.Data
{
    public class DataImporter
    {
        public List<House> ImportData()
        {
            string file = "HouseData.json";
            string jsonData = File.ReadAllText(file);
            var houseData = JsonSerializer.Deserialize<List<House>>(jsonData);
            return houseData;
        }

    }
}
