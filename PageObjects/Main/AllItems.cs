using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncorrupted.PageObjects.Main
{
    public class AllItems : MainPage
    {
        public SelectElement sorting;
        public ReadOnlyCollection<IWebElement> items;
        public IWebElement buyBackPack;
        public IWebElement buyBikeLight;
        public IWebElement buyFleeceJacket;
        public IWebElement backPackItemLink;
        public AllItems() {
            sorting = new SelectElement(driver.FindElement(By.CssSelector("*[data-test=\"product_sort_container\"]")));
            buyBackPack = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            buyFleeceJacket = driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
            buyBikeLight = driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
            backPackItemLink = driver.FindElement(By.Id("item_4_title_link"));
        }

        public bool isSortedBy(string type)
        {
            List<String> checkList = new List<String>();
            List<String> realList= new List<String>();
            items = driver.FindElements(By.ClassName("inventory_item"));
            for (int i = 0; i < items.Count; i++)
            {
                IWebElement itemName = items[i].FindElement(By.ClassName("inventory_item_name"));
                checkList.Add(itemName.Text);
                realList.Add(itemName.Text);
            }
            checkList.Sort();
            if (type == "ZA")
            {
                checkList.Reverse();
            }
            return Enumerable.SequenceEqual(checkList, realList);
        }

        public bool isSortedByPrice(string type)
        {
            List<Double> checkList = new List<Double>();
            List<Double> realList = new List<Double>();
            items = driver.FindElements(By.ClassName("inventory_item"));
            for (int i = 0; i < items.Count; i++)
            {
                Double itemPrice = Convert.ToDouble(items[i].FindElement(By.ClassName("inventory_item_price")).Text.Remove(0, 1).Replace('.', ','));
                checkList.Add(itemPrice);
                realList.Add(itemPrice);
            }
            checkList.Sort();
            if (type == "LH")
            {
                checkList.Reverse();
            }
            return Enumerable.SequenceEqual(checkList, realList);
        }

        public Item clickOnBackPackLink()
        {
            backPackItemLink.Click();
            return new Item();
        }
    }
}
