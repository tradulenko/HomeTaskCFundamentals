using HomeTaskUsingSelenium.Pages.Elements;
using HomeTaskUsingSelenium.Pages.PageWithLeftMenu;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskUsingSelenium.Pages.ParentPageWithLeftMenu
{
    abstract public class ParentPageWithLeftMenuPage : ParentPage
    {

        [FindsBy(How = How.XPath, Using = ".//*[@class='oxd-topbar-header-userarea']//*[@alt='profile picture']")]
        private IWebElement AvatarOnHeader { get; set; }

        public readonly LeftMainMenu LeftMainMenu;
        public ParentPageWithLeftMenuPage(IWebDriver webDriver) : base(webDriver)
        {
            LeftMainMenu = new LeftMainMenu(webDriver);
        }
        [AllureStep]
        public bool IsAvatarDisplayed()
        {
            try
            {
                return AvatarOnHeader.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        [AllureStep]
        public DashboardPage CheckIsAvatarDisplayed()
        {
            Assert.IsTrue(IsAvatarDisplayed(), "Avatar is not displayed");
            Console.WriteLine("Avatar is displayed");
            return new DashboardPage(webDriver);

        }
    }
}
