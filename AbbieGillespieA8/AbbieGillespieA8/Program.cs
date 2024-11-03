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
            driver.LamMoreThanFive();
            driver.GoodPrice();
            driver.GoodPriceLam();
            driver.ThreeStates();
            driver.ThreeStatesLam();
            driver.HouseZipCodes();
            driver.HouseZipCodesLam();
            driver.HousesByState();
            driver.HousesByStateLam();
            driver.HouseUnderFourMonths();
            driver.HouseUnderFourMonthsLam();
        }
    }
}
