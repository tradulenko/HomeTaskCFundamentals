using OpenQA.Selenium;


namespace HomeTaskUsingSelenium.Pages.PageWithLeftMenu.AdminSubPages.PayGrades
{
    public class PayGradesPage : AdminParentPageWithTopMenu
    {

        public Elements.AddPayGradeContainer AddPayGradeContainer
        {
            get { return new Elements.AddPayGradeContainer(webDriver); }
        }

        public Elements.PayGradeContainer PayGradeContainer
        {
            get { return new Elements.PayGradeContainer(webDriver); }
        }

        public Elements.AddCurrencyContainer AddCurrencyContainer
        {
            get { return new Elements.AddCurrencyContainer(webDriver); }
        }

        public Elements.CurrenciesContainer CurrenciesContainer
        {
            get { return new Elements.CurrenciesContainer(webDriver); }
        }

     
        public PayGradesPage(IWebDriver webDriver) : base(webDriver)
        {
        }


    }
}
