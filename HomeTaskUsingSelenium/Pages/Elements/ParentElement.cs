using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace HomeTaskUsingSelenium.Pages.Elements
{
    public class ParentElement
    {
        protected IWebDriver driver;

        public ParentElement(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
