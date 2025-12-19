using Tyuiu.chernyhim.Sprint7.Project.V2.Lib;
namespace Tyuiu.chernyhim.Sprint7.Project.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMinRevenue_ReturnsCorrectValue()
        {
            DataService ds = new DataService();
            int result = ds.GetMinRevenue();

            Assert.AreEqual(27000, result);
        }

    }
}
