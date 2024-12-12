﻿using Tyuiu.AsharabzyanovaAR.Sprint6.Task7.V5.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, File.Exists(@"C:\Users\User\source\repos\Tyuiu.SaigafarovBI.Sprint6\gg.csv"));
        }
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.SaigafarovBI.Sprint6\gg.csv";

            int[,] wait = new int[10, 10]
            {
                {15,3,-4,-12,-2, 11, 10, -4, -17, 5},
                {11, -10, -3, -9, 9, 16, -2, 4, 15, 2 },
                {-4,-14, 11, -8, -3, -19, -13, 12, -13, 2 },
                {18,4, -5, 16, -17, -2, -6, 2, -17, 17 },
                {-18,-12, -10, 20, 12, -15, -7, -9, 18, 14 },
                {-6, -4, -11, -3, -7, -19, -1, 1, 20, 2 },
                {-11,-19, -16, 1, 1, 19, 9, 1, -18, 2},
                {-13,-2, -19, 3, 0, 0, -20, -20, -1, 2 },
                {0, -20, -16, 16, 1, -14, 18, -3, 5, 12 },
                {18, -14, 0, 6, -7, 5, -14, -9, 16, 2 },

            };
            CollectionAssert.AreEqual(ds.GetMatrix(path), wait);
        }
    }
}