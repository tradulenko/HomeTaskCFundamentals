using HomeTaskUsingSelenium.Pages.PageWithLeftMenu;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskUsingSelenium.Pages
{
    [TestFixture]
    public class LoginPage : ParentPage
    {
        
        [FindsBy(How = How.XPath, Using = ".//*[contains(@class,'oxd-sheet')]//p[1]")]
        public IWebElement TextLogin { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[contains(@class,'oxd-sheet')]//p[2]")]
        public IWebElement TextPassword { get; set; }

        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement InputUserName { get; set; }


        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement InputPassword { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@type='submit']")]
        public IWebElement ButtonLogin { get; set; }


        

        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public LoginPage OpenLoginPage()
        {
            webDriver.Url = "https://opensource-demo.orangehrmlive.com/";
            Console.WriteLine("Login page was opened");
            return this;
        }

        public LoginPage EnterTextIntoInputUserName(string userName)
        {
            InputUserName.SendKeys(userName);
            Console.WriteLine(userName + " was inputed in UserName");
            return this;
        }

        public LoginPage EnterTextIntoInputUserName()
        {
            string userName = TextLogin.Text.Replace("Username : ", "").Trim();
            InputUserName.SendKeys(userName);
            Console.WriteLine(userName + " was inputed in UserName");
            return this;
        }

        public LoginPage EnterTextInPassWord(string passWord)
        {
            InputPassword.SendKeys(passWord);
            Console.WriteLine(passWord + " was inputed in UserName");
            return this;
        }

        public LoginPage EnterTextInPassWord()
        {
            string passWord = TextPassword.Text.Replace("Password : ", "").Trim();
            InputPassword.SendKeys(passWord);
            Console.WriteLine(passWord + " was inputed in UserName");
            return this;
        }

        public DashboardPage ClickOnButtonSubmit()
        {
            ButtonLogin.Click();
            Console.WriteLine("Button submit was clicked");
            return new DashboardPage(webDriver);
        }

    }
}
