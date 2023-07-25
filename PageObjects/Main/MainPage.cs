using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncorrupted.PageObjects.Main
{
    public class MainPage
    {
        public IWebElement cart;
        public MainPage() {
            cart = driver.FindElement(By.CssSelector("a[class= \"shopping_cart_link\"]"));
        }

        public Cart clickOnCart()
        {
            cart.Click();
            return new Cart();
        }

        public bool checkBadgeNumber(string numberShouldBe) => 
            cart.FindElement(By.ClassName("shopping_cart_badge")).Text == numberShouldBe;


            
    }
}