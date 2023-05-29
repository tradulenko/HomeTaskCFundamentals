using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace HomeTaskUsingSelenium.Pages.Elements
{
    public class LeftMainMenu : ParentElement
    {
        public LeftMainMenu(IWebDriver driver) : base(driver)
        {
            
        }

        [FindsBy(How = How.XPath, Using = ".//*[@class='oxd-main-menu']")]
        private IWebElement LeftMenuWebElement { get; set; }

        public IWebElement GetMenuWithName(LeftMenuItems leftMenuItems)
        {
            return LeftMenuWebElement.FindElement(By.XPath("//*[text()='"+ leftMenuItems + "']"));
        }

        public void ClickOnLeftMenuItem(LeftMenuItems leftMenu)
        {
            GetMenuWithName(leftMenu).Click();
            Console.WriteLine(leftMenu + "Menu was clicked");
        }

        public enum LeftMenuItems
        {
            Admin,
            PIM,
            Leave,
            Time,
            Recruitment
        }


    }
}
