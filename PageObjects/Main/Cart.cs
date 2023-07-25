using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncorrupted.PageObjects.Main
{
    public class Cart : MainPage
    {
        public IWebElement checkout;
        public ReadOnlyCollection<IWebElement> itemsInCart;

        public Cart() {
            checkout = driver.FindElement(By.Id("checkout"));
        }

        public bool checkItemsInCart(List<string> itemsShouldBe)
        {
            itemsInCart = driver.FindElements(By.ClassName("cart_item"));
            List<string> realList = new List<string> { };
            for (int i = 0; i < itemsInCart.Count; i++) {
                if(!itemsShouldBe.Contains(itemsInCart[i].FindElement(By.ClassName("inventory_item_name")).Text.Trim()))
                {
                    return false;
                }
            }
            return true;
        }

        public CheckoutCreds clickCheckout()
        {
            checkout.Click();
            return new CheckoutCreds();
        }
    }
}
