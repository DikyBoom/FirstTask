using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncorrupted.PageObjects.Main
{
    public class Item : MainPage
    {
        public IWebElement itemImage;
        public IWebElement itemName;
        public IWebElement itemDescription;
        public IWebElement itemPrice; 

        public Item() {
            itemImage = driver.FindElement(By.ClassName("inventory_details_img"));
            itemName = driver.FindElement(By.CssSelector("*[class=\"inventory_details_name large_size\"]"));
            itemDescription = driver.FindElement(By.CssSelector("*[class=\"inventory_details_desc large_size\"]"));
            itemPrice = driver.FindElement(By.ClassName("inventory_details_price"));
        }
    }
}
