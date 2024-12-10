using Tyuiu.AsharabzyanovaAR.Sprint6.Task5.V21.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"D:\Рабочий Стол\t\Tyuiu.AsharabzyanovaAR.Sprint6\Tyuiu.AsharabzyanovaAR.Sprint6.Task5.V21\bin\Debug\net8.0-windows\InPutDataFileTask5V21.txt";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}
