using HomeTaskUsingSelenium.Pages.Elements;
using HomeTaskUsingSelenium.Pages.ParentPageWithLeftMenu;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskUsingSelenium.Pages.PageWithLeftMenu
{
    public class AdminPage : ParentPageWithLeftMenuPage
    {
        [FindsBy(How = How.XPath, Using = ".//*[text()='Job ']")]
        public IWebElement MenuJob { get; set; }

        public JobMenu JobMenu { get; set; }

        public AdminPage(IWebDriver webDriver) : base(webDriver)
        {
            JobMenu = new JobMenu(webDriver);
        }

        public AdminPage OpenJobMenu()
        {
            MenuJob.Click();
            Console.WriteLine("Menu Job was clicked");
            return this;
        }




    }
}
