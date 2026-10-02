using System.Globalization;
using Tyuiu.WarkentinMA.Sprint1.Task6.V3.Lib;

namespace Tyuiu.WarkentinMA.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string x = "привет меня зовут максим";
            var res = ds.LastLetterWord(x);
            string wait = "тятм";
            Assert.AreEqual(wait, res);
        }
    }
}
