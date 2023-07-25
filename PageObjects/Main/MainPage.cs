using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncorrupted.PageObjects.Main
{
    internal class MainPage
    {
        public IWebElement cart;
        public MainPage() {
            cart = driver.FindElement(By.CssSelector("a[class= \"shopping_cart_link\"]"));
        }
    }
}