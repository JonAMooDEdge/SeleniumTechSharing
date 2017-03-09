using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTechSession.PageModel
{
    public class Login : PageModel
    {
        private PageFactory.Login login { get; set; }

        public Login(IWebDriver driver) : base(driver)
        {
            login = new PageFactory.Login(driver);
        }

        public void LoginDetails(string userName, string password)
        {
            login.Username.SendKeys(userName);

            login.Password.SendKeys(password);

            login.LoginButton.Click();
        }

        public string ErrorMessage()
        {
            return login.ErrorMessage.Text;
        }

        internal void ClearText()
        {
            login.Username.Clear();
            login.Password.Clear();
        }
    }
}
