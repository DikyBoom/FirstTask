using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uncorrupted.GlobalAndConst;
using Uncorrupted.PageObjects.Login;
using Uncorrupted.PageObjects.Main;

namespace Uncorrupted.Tests
{
    internal class AllItemsTests : BaseTest
    {
        [Test]
        public void defaultSortingOfProducts()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys(goodUserName);
            loginPage.password.SendKeys(password);
            loginPage.loginButton.Click();

            AllItems allItems = new AllItems();

            Assert.That(allItems.isSortedBy("AZ"));
        }

        [Test]
        public void reverseAlphabeticalSortingOfProducts()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys(goodUserName);
            loginPage.password.SendKeys(password) ;
            loginPage.loginButton.Click();

            AllItems allItems = new AllItems();

            allItems.sorting.SelectByValue("za");

            Assert.That(allItems.isSortedBy("ZA"));
        }

        [Test]
        public void SortingOfProductsByPriceHL()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys(goodUserName);
            loginPage.password.SendKeys(password);
            loginPage.loginButton.Click();

            AllItems allItems = new AllItems();

            allItems.sorting.SelectByValue("lohi");

            Assert.That(allItems.isSortedByPrice("HL"));
        }

        [Test]
        public void SortingOfProductsByPriceLH()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys(goodUserName);
            loginPage.password.SendKeys(password);
            loginPage.loginButton.Click();

            AllItems allItems = new AllItems();

            allItems.sorting.SelectByValue("hilo");

            Assert.That(allItems.isSortedByPrice("LH"));
        }
    }
}
