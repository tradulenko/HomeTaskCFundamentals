using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace HomeTaskUsingSelenium.Pages.PageWithLeftMenu.AdminSubPages.PayGrades.Elements
{
    public class AddCurrencyContainer : Container
    {
        readonly string DropDownCurrencyLocator = ".//*[text()='Add Currency']//..//form//div[@class='oxd-select-wrapper']//i";

        readonly string MinimumSalaryInputLocator = ".//*[text()='Add Currency']//..//form//div//div//div[.//*[contains(text(),'Minimum')]]//input";

        readonly string MaximumSalaryInputLocator = ".//*[text()='Add Currency']//..//form//div//div//div[.//*[contains(text(),'Maximum')]]//input";
        public AddCurrencyContainer(IWebDriver webDriver) : base(Elements.Container.ContainerName.AddCurrency, webDriver)
        {
        }

        private IWebElement DropDownCurrency()
        {
            return ContainerElement.FindElement(By.XPath(DropDownCurrencyLocator));
        }

        private IWebElement MinimumSalaryInput()
        {
            return ContainerElement.FindElement(By.XPath(MinimumSalaryInputLocator));
        }

        private IWebElement MaximumSalaryInput()
        {
            return ContainerElement.FindElement(By.XPath(MaximumSalaryInputLocator));
        }

        [AllureStep]
        public PayGradesPage SelectInDropDownCurrency(string _currecy)
        {

            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(7));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException), typeof(ElementClickInterceptedException));

            wait.Until(d => DropDownCurrency().Displayed == true);
            wait.Until(ExpectedConditions.ElementToBeClickable(DropDownCurrency()));

            DropDownCurrency().Click();

            webDriver.FindElement(By.XPath(".//*[text()='" + _currecy + "']")).Click();
            Console.WriteLine("'" + _currecy + "' was selected");
            return new PayGradesPage(webDriver);
        }
        [AllureStep]
        public PayGradesPage SetMinimumSalary(int amount)
        {
            MinimumSalaryInput().SendKeys(amount.ToString());
            Console.WriteLine(amount.ToString() + " was inputed to Input Minimum Salary");
            return new PayGradesPage(webDriver);
        }
        [AllureStep]
        public PayGradesPage SetMaximumSalary(int amount)
        {
            MaximumSalaryInput().SendKeys(amount.ToString());
            Console.WriteLine(amount.ToString() + " was inputed to Input Maximum Salary");
            return new PayGradesPage(webDriver);
        }

    }
}
