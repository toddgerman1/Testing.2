﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApplication1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
            Console.Write("Hello World");
            Assert.IsFalse(false);
        }
    }
}
