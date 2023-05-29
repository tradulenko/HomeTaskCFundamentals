using HomeTaskUsingSelenium.Pages.PageWithLeftMenu;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskUsingSelenium.Pages
{
    public class PageProvider
    {
        private IWebDriver webDriver;
        public PageProvider(IWebDriver webDriver) {
            this.webDriver = webDriver;    
        }
        
        public LoginPage GetLoginPage()
        {
            return new LoginPage(webDriver);
        }

        public AdminPage GetAdminPage()
        {
            return new AdminPage(webDriver);
        }

        public DashboardPage GetDashboardPage()
        {
            return new DashboardPage(webDriver);
        }
    }


}
