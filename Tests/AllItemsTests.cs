using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            loginPage.userName.SendKeys("standard_user");
            loginPage.password.SendKeys("secret_sauce");
            loginPage.loginButton.Click();

            AllItems allItems = new AllItems();

            Assert.That(allItems.isSortedByAZ);
        }

        [Test]
        public void reverseAlphabeticalSortingOfProducts()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys("standard_user");
            loginPage.password.SendKeys("secret_sauce");
            loginPage.loginButton.Click();

            AllItems allItems = new AllItems();

            allItems.sorting.SelectByValue("za");

            Assert.That(allItems.isSortedByZA);
        }

        [Test]
        public void SortingOfProductsByPriceHL()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys("standard_user");
            loginPage.password.SendKeys("secret_sauce");
            loginPage.loginButton.Click();

            AllItems allItems = new AllItems();

            allItems.sorting.SelectByValue("lohi");

            Assert.That(allItems.isSortedByPriceHL);
        }

        [Test]
        public void SortingOfProductsByPriceLH()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys("standard_user");
            loginPage.password.SendKeys("secret_sauce");
            loginPage.loginButton.Click();

            AllItems allItems = new AllItems();

            allItems.sorting.SelectByValue("hilo");

            Assert.That(allItems.isSortedByPriceLH);
        }
    }
}
