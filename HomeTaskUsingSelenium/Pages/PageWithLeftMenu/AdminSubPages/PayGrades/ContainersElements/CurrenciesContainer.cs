using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace HomeTaskUsingSelenium.Pages.PageWithLeftMenu.AdminSubPages.PayGrades.Elements
{
    public class CurrenciesContainer : Container
    {

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-table-card']//*[@role='row']")]
        public IList<IWebElement> TableRowCurrency { get; set; }
        public CurrenciesContainer( IWebDriver webDriver) : base(Elements.Container.ContainerName.Currencies, webDriver)
        {
        }
        [AllureStep]
        public PayGradesPage CheckCurrencies(int expectedMinSalary, int expectedMaxSalary, int expectedNumberOfRecords)
        {
            string locatorMinSalarySell = ".//div[@class='oxd-table-cell oxd-padding-cell'][3]";
            string locatorMaxSalarySell = ".//div[@class='oxd-table-cell oxd-padding-cell'][4]";

            IList<IWebElement> newList = TableRowCurrency
                .Where(x => x.FindElement(By.XPath(locatorMinSalarySell)).Text.Equals(expectedMinSalary + ".00"))
                .Where(x => x.FindElement(By.XPath(locatorMaxSalarySell)).Text.Equals(expectedMaxSalary + ".00"))
                .ToList();
            Assert.AreEqual(expectedNumberOfRecords, newList.Count(), "Number of records with " + expectedMinSalary + ".00 " + expectedMaxSalary + ".00 sould be");

            return new PayGradesPage(webDriver);
        }
    }
}
