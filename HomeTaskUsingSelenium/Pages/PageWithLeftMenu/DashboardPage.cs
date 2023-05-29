using HomeTaskUsingSelenium.Pages.ParentPageWithLeftMenu;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskUsingSelenium.Pages.PageWithLeftMenu
{
    public class DashboardPage : ParentPageWithLeftMenuPage
    {
        public DashboardPage(IWebDriver webDriver) : base(webDriver)
        {
        }
    }
}
