using NUnit.Framework;
using OpenQA.Selenium;
using HomeTaskUsingSelenium.Pages.PageWithLeftMenu.AdminSubPages;
using NUnit.Allure.Attributes;

namespace HomeTaskUsingSelenium.Pages.Elements
{
    public class JobMenu : ParentElement
    {
        public JobMenu(IWebDriver driver) : base(driver)
        {

        }

        [AllureStep]
        public AdminSubPagesProvider ClickOnSubMenuPayGrades(JobMenuItems role)
        {
            string _roleStr = GetTextJobMenuItems(role);
            try
            {
                driver.FindElement(By.XPath(".//ul[@class='oxd-dropdown-menu']//li/a[text()='" + _roleStr + "']")).Click();
                Console.WriteLine("SubMenu '" + _roleStr + "' was clicked");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can`t click on subMenu '" + _roleStr + "' \n" + ex.Message);
                Assert.Fail("Can`t click on subMenu '" + _roleStr + "'");
            }

            return new AdminSubPagesProvider(driver);
        }

        private readonly Dictionary<JobMenuItems, string> TextJobMenuItems = new Dictionary<JobMenuItems, string>
        {
            {JobMenuItems.JobTitles, "Job Titles" },
            {JobMenuItems.PayGrades, "Pay Grades" }

        };

        public String GetTextJobMenuItems(JobMenuItems subMenu)
        {
            return TextJobMenuItems[subMenu];
        }


        public enum JobMenuItems
        {
            JobTitles,
            PayGrades
        }

    }
}
