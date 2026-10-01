using Tyuiu.WarkentinMA.Sprint1.Task0.V26.Lib;

namespace Tyuiu.WarkentinMA.Sprint1.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(7, res);
        }
    }
}
