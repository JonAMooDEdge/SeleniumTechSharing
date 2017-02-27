using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTechSession.PageModel
{
    public abstract class PageModel
    {
        public Dictionary<string, string> data { get; set; }

        public WebDriverWait wait { get; set; }

        public IWebDriver _driver { get; set; }

        public PageModel(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            data = DictfromFile();
        }

        internal Dictionary<string, string> DictfromFile()
        {
            string fileName = $"PageModel\\Data\\Data.json";

            string[] readFile = File.ReadAllLines(fileName);

            string json = "";

            foreach (string line in readFile)
            {
                json += line;
            }

            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
    }
}
