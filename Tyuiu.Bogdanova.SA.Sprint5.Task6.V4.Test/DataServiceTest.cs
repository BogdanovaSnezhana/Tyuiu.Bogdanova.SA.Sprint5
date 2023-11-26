using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.Bogdanova.SA.Sprint5.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {

        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V4.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }


    }
}
