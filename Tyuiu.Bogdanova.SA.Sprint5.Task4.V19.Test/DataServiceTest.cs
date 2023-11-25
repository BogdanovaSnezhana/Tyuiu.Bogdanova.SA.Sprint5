using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.Bogdanova.SA.Sprint5.Task4.V19.Lib;

namespace Tyuiu.Bogdanova.SA.Sprint5.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test4()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V19.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }



    }
}
