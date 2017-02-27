using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTechSession
{
    public class Setup : IDisposable
    {
        private IWebDriver driver { get; set; }

        public Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument($"app={Env.EnvSettings.envUrl}");

            driver = new ChromeDriver(options);
        }

        public void Dispose()
        {
            driver.Quit();
        }

        internal IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
