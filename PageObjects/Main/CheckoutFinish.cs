using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncorrupted.PageObjects.Main
{
    public class CheckoutFinish : MainPage
    {
        public IWebElement thankYou;
        public IWebElement backButton;
        public CheckoutFinish() {
            thankYou = driver.FindElement(By.ClassName("complete-header"));
            backButton = driver.FindElement(By.Id("back-to-products"));
        }
        
        public AllItems clickBack()
        {
            backButton.Click();
            return new AllItems();
        }
    }
}
