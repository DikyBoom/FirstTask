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
        public AllItems() {
            sorting = new SelectElement(driver.FindElement(By.CssSelector("*[data-test=\"product_sort_container\"]")));
            buyBackPack = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            buyFleeceJacket = driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
            buyBikeLight = driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
        }

        public bool isSortedByAZ()
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
            return Enumerable.SequenceEqual(checkList, realList);
        }

        public bool isSortedByZA()
        {
            List<String> checkList = new List<String>();
            List<String> realList = new List<String>();
            items = driver.FindElements(By.ClassName("inventory_item"));
            for (int i = 0; i < items.Count; i++)
            {
                IWebElement itemName = items[i].FindElement(By.ClassName("inventory_item_name"));
                checkList.Add(itemName.Text);
                realList.Add(itemName.Text);
            }
            checkList.Sort();
            checkList.Reverse();
            return Enumerable.SequenceEqual(checkList, realList);
        }
        public bool isSortedByPriceHL()
        {
            List<Double> checkList = new List<Double>();
            List<Double> realList = new List<Double>();
            items = driver.FindElements(By.ClassName("inventory_item"));
            for (int i = 0; i < items.Count; i++)
            {
                IWebElement itemName = items[i].FindElement(By.ClassName("inventory_item_price"));
                checkList.Add(Convert.ToDouble(itemName.Text.Remove(0, 1)));
                realList.Add(Convert.ToDouble(itemName.Text.Remove(0, 1)));
            }
            checkList.Sort();
            return Enumerable.SequenceEqual(checkList, realList);
        }

        public bool isSortedByPriceLH()
        {
            List<Double> checkList = new List<Double>();
            List<Double> realList = new List<Double>();
            items = driver.FindElements(By.ClassName("inventory_item"));
            for (int i = 0; i < items.Count; i++)
            {
                IWebElement itemName = items[i].FindElement(By.ClassName("inventory_item_price"));
                checkList.Add(Convert.ToDouble(itemName.Text.Remove(0, 1)));
                realList.Add(Convert.ToDouble(itemName.Text.Remove(0, 1)));
            }
            checkList.Sort();
            checkList.Reverse();
            return Enumerable.SequenceEqual(checkList, realList);
        }
    }
}
