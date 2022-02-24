﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pract14
{
    public class BaseTest
    {
        [ThreadStatic] protected static IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
