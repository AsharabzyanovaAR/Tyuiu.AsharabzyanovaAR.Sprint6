using Tyuiu.AsharabzyanovaAR.Sprint6.Task0.V21.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValideCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 11;
            Assert.AreEqual(wait, res);
        }
    }
}