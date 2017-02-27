using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTechSession.Tests
{
    public abstract class Test
    {
        private IWebDriver driver { get; set; }

        private PageModel.Login login { get; set; }

        internal Test(Setup setup)
        {
            driver = setup.GetDriver();

            login = new PageModel.Login(driver);
        }
    }
}
