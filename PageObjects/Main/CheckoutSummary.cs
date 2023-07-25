using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncorrupted.PageObjects.Main
{
    public class CheckoutSummary : MainPage
    {
        public IWebElement totalAmount;
        public IWebElement finish;

        public CheckoutSummary()
        {
            totalAmount = driver.FindElement(By.CssSelector("*[class=\"summary_info_label summary_total_label\"]"));
            finish = driver.FindElement(By.Id("finish"));
        }

        public CheckoutFinish clickFinish()
        {
            finish.Click();
            return new CheckoutFinish();
        }
    }
}
