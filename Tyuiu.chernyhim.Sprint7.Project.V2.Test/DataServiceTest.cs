using Tyuiu.chernyhim.Sprint7.Project.V2.Lib;

namespace Tyuiu.chernyhim.Sprint7.Project.V2.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void CalculateTotalRevenue_ValidArray_ReturnsCorrectSum()
        {
            
            DataService ds = new DataService();
            int[] revenues = { 10000, 20000, 30000 };

            
            int result = ds.CalculateTotalRevenue(revenues);


            Assert.AreEqual(60000, result);
        }
        [TestMethod]

        public void CalculateStatistics_ValidArray_ReturnsCorrectValues()
        {

            DataService ds = new DataService();
            int[] revenues = { 10000, 20000, 30000 };


            var result = ds.CalculateStatistics(revenues);


            Assert.AreEqual(10000, result.min);
            Assert.AreEqual(30000, result.max);
            Assert.AreEqual(20000, result.avg);
        }
    }
}

