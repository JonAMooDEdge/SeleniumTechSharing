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
        public IWebDriver driver { get; set; }

        public PageModel.Login login { get; set; }

        public Test(Setup setup)
        {
            driver = setup.GetDriver();

            login = new PageModel.Login(driver);
        }
    }
}
