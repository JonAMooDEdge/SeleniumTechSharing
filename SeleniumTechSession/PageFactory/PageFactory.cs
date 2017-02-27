using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTechSession.PageFactory
{    
    public abstract class PageFactory
    {
        private IWebDriver _driver { get; set; }

        public PageFactory(IWebDriver driver)
        {
            _driver = driver;
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(this, new RetryingElementLocator(_driver));
        }
    }
    
}
