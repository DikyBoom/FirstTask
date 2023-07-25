using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncorrupted.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }
    }
}
