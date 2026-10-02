using Tyuiu.WarkentinMA.Sprint1.Task7.V18.Lib;

namespace Tyuiu.WarkentinMA.Sprint1.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 6;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(4.22, res);

        }
    }
}
