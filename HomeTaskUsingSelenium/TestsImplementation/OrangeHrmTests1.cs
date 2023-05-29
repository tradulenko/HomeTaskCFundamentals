using NUnit.Framework;
using HomeTaskUsingSelenium.Pages.Elements;

using HomeTaskUsingSelenium.Data;

namespace HomeTaskUsingSelenium.TestsImplementation
{

    [TestFixture]
    public class OrangeHrmTests1 : BaseTest
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

        [Test]
        public void Scenario_1()
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
                // Additional Currency
                .PayGradesPage.AddCurrencyContainer.SelectInDropDownCurrency("AFN - Afghanistan Afghani")
                              .AddCurrencyContainer.SetMinimumSalary(PayGradesData.MinSalary + 1)
                              .AddCurrencyContainer.SetMaximumSalary(PayGradesData.MaxSalary + 1)
                              .AddCurrencyContainer.ClickOnSaveButton()
                .PayGradesPage.CurrenciesContainer.CheckCurrencies(PayGradesData.MinSalary + 1, PayGradesData.MaxSalary + 1, 1)
                // Currency from task
                              .CurrenciesContainer.ClickOnButtonAdd()
                .PayGradesPage.AddCurrencyContainer.SelectInDropDownCurrency("UAH - Ukraine Hryvnia")
                            .AddCurrencyContainer.SetMinimumSalary(PayGradesData.MinSalary)
                            .AddCurrencyContainer.SetMaximumSalary(PayGradesData.MaxSalary)
                            .AddCurrencyContainer.ClickOnSaveButton()
                .PayGradesPage.CurrenciesContainer.CheckCurrencies(PayGradesData.MinSalary, PayGradesData.MaxSalary, 1)
                    ;



        }
        [TearDown]
        public void DeletePayGrades()
        {
            pageProvider.GetAdminPage()
                .OpenJobMenu()
                .JobMenu.ClickOnSubMenuPayGrades(JobMenu.JobMenuItems.PayGrades)
                .PayGradesPage.PayGradeContainer.DeleteCreatedPayGrade();
        }
    }
}
