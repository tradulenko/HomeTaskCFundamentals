using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace HomeTaskUsingSelenium.Pages.PageWithLeftMenu.AdminSubPages.PayGrades.Elements
{
    
    abstract public class Container
    {
        protected IWebDriver webDriver;
        protected IWebElement ContainerElement;
        private ContainerName containerName;

        readonly string _ButtonAdd = ".//*[@class='oxd-button oxd-button--medium oxd-button--secondary']";

        readonly string _buttonSave = ".//form[@class='oxd-form']//button[@type='submit']";
        readonly string _buttonCancel = ".//form[@class='oxd-form']//button[@type='button']";


        public Container(ContainerName nameContainer, IWebDriver webDriver) { 
            
            this.webDriver = webDriver;
            this.containerName = nameContainer;
            this.ContainerElement = webDriver.FindElement(By.XPath(".//*[text()='" + GetTextJobMenuItems(nameContainer) + "']//.."));
            PageFactory.InitElements(webDriver, this);
        }



        public IWebElement ButtonAdd { get
            {
                return ContainerElement.FindElement(By.XPath(_ButtonAdd));
            } }

        [AllureStep]
        public AdminSubPagesProvider ClickOnButtonAdd()
        {

            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(2));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException), typeof(ElementClickInterceptedException));
            wait.Until(ExpectedConditions.ElementToBeClickable(ContainerElement.FindElement(By.XPath(_ButtonAdd))));

            ContainerElement.FindElement(By.XPath(_ButtonAdd)).Click();
            Console.WriteLine("Button Add was clicker in block " + containerName);
            return new AdminSubPagesProvider(webDriver);
        }

        [AllureStep]
        public AdminSubPagesProvider ClickOnSaveButton()
        {
            ContainerElement.FindElement(By.XPath(_buttonSave)).Click();
            Console.WriteLine("Button Save was clicker in block " + containerName);

            WaitSpinerToBeHide();

            return new AdminSubPagesProvider(webDriver);
        }

        [AllureStep]
        public AdminSubPagesProvider ClickOnCancelButton()
        {
            ContainerElement.FindElement(By.XPath(_buttonCancel)).Click();
            Console.WriteLine("Button Save was clicker in block " + containerName);

            WaitSpinerToBeHide();

            return new AdminSubPagesProvider(webDriver);
        }

        protected void WaitSpinerToBeHide()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(".//*[@class='oxd-loading-spinner']")));
        }

        private readonly Dictionary<ContainerName, string> NameOfContainer = new Dictionary<ContainerName, string>
        {
            
            {ContainerName.PayGrades, "Pay Grades" },
            {ContainerName.AddPayGrade, "Add Pay Grade" },
            {ContainerName.EditPayGrade, "Edit Pay Grade" },
            {ContainerName.Currencies, "Currencies" },
            {ContainerName.AddCurrency, "Add Currency" }

        };

        private String GetTextJobMenuItems(ContainerName containerName)
        {
            return NameOfContainer[containerName];
        }

        public enum ContainerName
        {
            PayGrades,
            AddPayGrade,
            EditPayGrade,
            Currencies,
            AddCurrency
        }
    }
}
