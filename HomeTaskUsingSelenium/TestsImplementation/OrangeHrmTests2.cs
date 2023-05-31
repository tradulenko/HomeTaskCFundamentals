using NUnit.Framework;
using HomeTaskUsingSelenium.Pages.Elements;

using HomeTaskUsingSelenium.Data;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;

namespace HomeTaskUsingSelenium.TestsImplementation
{

    [TestFixture]
    [AllureNUnit]
    [AllureSuite("HW tests")]
    public class OrangeHrmTests2 : BaseTest
    {
        [SetUp]
        public void LoginToApp()
        {
            pageProvider
                .GetLoginPage()
                    .OpenLoginPage()
                    .EnterTextIntoInputUserName()
                    .EnterTextInPassWord()
                    .ClickOnButtonSubmit()
                    .CheckIsAvatarDisplayed();

        }

        [Test(Description = "Test 2")]
        public void Scenario_2()
        {
            pageProvider
                .GetDashboardPage()
                    .CheckIsAvatarDisplayed()
                    .LeftMainMenu.ClickOnLeftMenuItem(LeftMainMenu.LeftMenuItems.Admin);
            pageProvider
                .GetAdminPage()
                    .OpenJobMenu()
                    .JobMenu.ClickOnSubMenuPayGrades(JobMenu.JobMenuItems.PayGrades)
                .PayGradesPage.PayGradeContainer.ClickOnButtonAdd()
                .PayGradesPage.AddPayGradeContainer.EnterRandomNameInInputName()
                    .AddPayGradeContainer.ClickOnSaveButton()
                .PayGradesPage.CurrenciesContainer.ClickOnButtonAdd()
                .PayGradesPage.AddCurrencyContainer.SelectInDropDownCurrency("AFN - Afghanistan Afghani")
                              .AddCurrencyContainer.SetMinimumSalary(PayGradesData.MinSalary + 1)
                              .AddCurrencyContainer.SetMaximumSalary(PayGradesData.MaxSalary + 1)
                              .AddCurrencyContainer.ClickOnSaveButton()
                .PayGradesPage.CurrenciesContainer.CheckCurrencies(PayGradesData.MinSalary + 1, PayGradesData.MaxSalary + 1, 1)
                              .CurrenciesContainer.ClickOnButtonAdd()
                .PayGradesPage.AddCurrencyContainer.SelectInDropDownCurrency("UAH - Ukraine Hryvnia")
                            .AddCurrencyContainer.SetMinimumSalary(PayGradesData.MinSalary)
                            .AddCurrencyContainer.SetMaximumSalary(PayGradesData.MaxSalary)
                            .AddCurrencyContainer.ClickOnCancelButton()
                .PayGradesPage.CurrenciesContainer.CheckCurrencies(PayGradesData.MinSalary, PayGradesData.MaxSalary, 0)
                    ;



        }

    }
}
