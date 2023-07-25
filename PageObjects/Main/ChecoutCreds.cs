using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncorrupted.PageObjects.Main
{
    public class CheckoutCreds : MainPage
    {
        public IWebElement firstName;
        public IWebElement lastName;
        public IWebElement zip;
        public IWebElement continueButton;

        public CheckoutCreds()
        {
            firstName = driver.FindElement(By.Id("first-name"));
            lastName = driver.FindElement(By.Id("last-name"));
            zip = driver.FindElement(By.Id("postal-code"));
            continueButton = driver.FindElement(By.Id("continue"));
        }

        public CheckoutSummary clickContinue()
        {
            continueButton.Click();
            return new CheckoutSummary();
        }
    }
}
