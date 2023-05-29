using HomeTaskUsingSelenium.Pages.Elements;
using HomeTaskUsingSelenium.Pages.ParentPageWithLeftMenu;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskUsingSelenium.Pages.PageWithLeftMenu.AdminSubPages
{
    public class AdminParentPageWithTopMenu : ParentPageWithLeftMenuPage
    {
        [FindsBy(How = How.XPath, Using = ".//*[text()='Job ']")]
        public IWebElement MenuJob { get; set; }

        public JobMenu JobMenu { get; set; }


        public AdminParentPageWithTopMenu(IWebDriver webDriver) : base(webDriver)
        {
            JobMenu = new JobMenu(webDriver);
        }

        public AdminPage OpenJobMenu()
        {
            MenuJob.Click();
            Console.WriteLine("Menu Job was clicked");
            return new AdminPage(webDriver);
        }
    }
}
