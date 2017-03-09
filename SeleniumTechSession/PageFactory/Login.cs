using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTechSession.PageFactory
{
    public class Login : PageFactory
    {
        public Login(IWebDriver driver) : base(driver) { }

        [FindsBy(How=How.Id, Using= "UserName")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "card-content")]
        public IWebElement ErrorMessage { get; set; }
    }
}
