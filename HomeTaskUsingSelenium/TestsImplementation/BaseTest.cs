using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTaskUsingSelenium.Pages;

namespace HomeTaskUsingSelenium.TestsImplementation
{
    [TestFixture]
    public class BaseTest
    {
#pragma warning disable CS8618
        protected IWebDriver driver;

        protected PageProvider pageProvider;
#pragma warning restore CS8618

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            pageProvider = new PageProvider(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
