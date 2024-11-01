using AbbieGillespieA8.Driver;

namespace AbbieGillespieA8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDriver driver = new MyDriver();
            driver.Run();
            driver.LongerThanFive();
            driver.GoodPrice();
            driver.ThreeStates();
            driver.HouseZipCodes();
            driver.HousesByState();
            driver.HouseUnderFourMonths();
        }
    }
}
