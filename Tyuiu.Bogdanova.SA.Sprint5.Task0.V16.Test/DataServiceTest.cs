﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.Bogdanova.SA.Sprint5.Task0.V16.Lib;
using System.IO;

namespace Tyuiu.Bogdanova.SA.Sprint5.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        
        
            public void CheckedExistsFile()
            {
                string path = @"C:\Users\Ghostxr\source\repos\Tyuiu.BogdanovaSA.Sprint5\Tyuiu.BogdanovaSA.Sprint5.Task0.V16\bin\Debug\OutPutFileTask0.txt";

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
        
    }
}
