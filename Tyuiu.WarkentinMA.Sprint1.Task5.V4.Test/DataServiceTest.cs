using Tyuiu.WarkentinMA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.WarkentinMA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 13257;
            var res = ds.SecondsToHours(x);
            Assert.AreEqual(3, res);
        }
    }
}
