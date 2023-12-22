using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PozhdinAA.Sprint7.Project.V12.Lib;

namespace Tyuiu.PozhdinAA.Sprint7.Project.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetData()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\xMeT1oRx\source\repos\Tyuiu.PozhdinAA.Sprint7\Tyuiu.PozhdinAA.Sprint7.Project.V12\bin\Back-end\personal_computer.csv";
            string[,] res = ds.GetData(path);

            string[,] wait = {
                { "MSI", "AMD Ryzen 5 3600", "8", "3,5", "16", "1000", "01.01.2020", "40000" },
                { "ASUS", "AMD Ryzen 7 1600", "6", "3,7", "16", "1000", "09.10.2015", "35000" }
            };

            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidAverageValue()
        {
            DataService ds = new DataService();

            double[] arrayNums = { 1, 2, 3 };

            double res = ds.AverageValue(arrayNums);

            double wait = 2;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidMinValue()
        {
            DataService ds = new DataService();

            double[] arrayNums = { 1, 2, 3 };

            double res = ds.MinValue(arrayNums);

            double wait = 1;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidMaxValue()
        {
            DataService ds = new DataService();

            double[] arrayNums = { 1, 2, 3 };

            double res = ds.MaxValue(arrayNums);

            double wait = 3;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidUpdateData()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\xMeT1oRx\Desktop\Копии экселей\test.csv";

            string[,] data = {
                { "AKA", "AKA", "AKA" },
                { "AKA", "AKA", "AKA" },
                { "AKA", "AKA", "AKA" },
                { "AKA", "AKA", "AKA" },
                { "AKA", "AKA", "AKA" }
            };

            bool res = ds.UpdateData(path, data);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
