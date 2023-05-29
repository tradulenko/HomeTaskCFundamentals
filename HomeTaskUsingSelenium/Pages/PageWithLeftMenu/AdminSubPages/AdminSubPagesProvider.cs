using HomeTaskUsingSelenium.Pages.PageWithLeftMenu.AdminSubPages.PayGrades;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskUsingSelenium.Pages.PageWithLeftMenu.AdminSubPages
{
    public class AdminSubPagesProvider 
    {
        private IWebDriver webDriver;
        public AdminSubPagesProvider(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public PayGradesPage PayGradesPage { get
            {
                return new PayGradesPage(webDriver);
            }
        }
    }

    
}
