using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using HomeTaskUsingSelenium.Data;
using NUnit.Allure.Attributes;

namespace HomeTaskUsingSelenium.Pages.PageWithLeftMenu.AdminSubPages.PayGrades.Elements
{
    public class PayGradeContainer : Container
    {
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-table-card']//*[@role='row']")]
        public IList<IWebElement> TableRowCurrency { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='orangehrm-modal-footer']//button[text()=' Yes, Delete ']")]
        public IWebElement ButtonDeleteYes { get; set; }
        
        public PayGradeContainer(IWebDriver webDriver) : base(Elements.Container.ContainerName.PayGrades, webDriver)
        {
        }
        [AllureStep]
        public PayGradesPage DeleteCreatedPayGrade()
        {
            string locatorNameCell = ".//div[@class='oxd-table-cell oxd-padding-cell'][2]";
            string locatorButtonDeleteCell = ".//div[@class='oxd-table-cell oxd-padding-cell'][4]//button[1]";

            IList<IWebElement> newListRowaWithCreatedGrade = TableRowCurrency
                .Where(x => x.FindElement(By.XPath(locatorNameCell)).Text.Equals(PayGradesData.Name))
                .ToList();

            Console.WriteLine("Number of Created Grades " + newListRowaWithCreatedGrade.Count());

            foreach (IWebElement newElement in newListRowaWithCreatedGrade)
            {
                newElement.FindElement(By.XPath(locatorButtonDeleteCell)).Click();
                ButtonDeleteYes.Click();
                Console.WriteLine("Button Delete Yes was clicked");
                WaitSpinerToBeHide();
            }

            newListRowaWithCreatedGrade = TableRowCurrency
                .Where(x => x.FindElement(By.XPath(locatorNameCell)).Text.Equals(PayGradesData.Name))
                .ToList();

            Assert.AreEqual(0, newListRowaWithCreatedGrade.Count(), "Created Gardes were not deleted");

            return new PayGradesPage(webDriver);
        }
    }
}
