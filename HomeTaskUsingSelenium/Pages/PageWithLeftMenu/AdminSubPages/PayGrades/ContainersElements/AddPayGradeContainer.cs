using Faker;
using HomeTaskUsingSelenium.Data;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HomeTaskUsingSelenium.Pages.PageWithLeftMenu.AdminSubPages.PayGrades.Elements
{
    public class AddPayGradeContainer : Container
    {
        [FindsBy(How = How.XPath, Using = ".//form[@class='oxd-form']//*[@class='oxd-input oxd-input--active']")]
        public IWebElement InputAddPayGradeFormName { get; set; }
        public AddPayGradeContainer(IWebDriver webDriver) : base(ContainerName.AddPayGrade, webDriver)
        {
        }

        public PayGradesPage EnterRandomNameInInputName()
        {

            InputAddPayGradeFormName.SendKeys(PayGradesData.Name);
            Console.WriteLine("'" + PayGradesData.Name + "' was entered as Name");
            return new PayGradesPage(webDriver);
        }
    }
}
