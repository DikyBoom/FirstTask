using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uncorrupted.PageObjects.Login;
using Uncorrupted.PageObjects.Main;

namespace Uncorrupted.Tests
{
    internal class BuyingProccessTests : BaseTest
    {
        [Test]
        public void checkoutWithThreeItems()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys(goodUserName);
            loginPage.password.SendKeys(password);
            loginPage.loginButton.Click();

            AllItems allItems = new AllItems();

            allItems.buyFleeceJacket.Click();
            allItems.buyBackPack.Click();
            allItems.buyBikeLight.Click();

            Cart cart = allItems.clickOnCart();

            Assert.That(cart.checkBadgeNumber("3"));

            Assert.That(cart.checkItemsInCart(new List<string> { "Sauce Labs Bike Light", "Sauce Labs Backpack", "Sauce Labs Fleece Jacket" }));

            CheckoutCreds checkoutCreds = cart.clickCheckout();

            checkoutCreds.firstName.SendKeys("Ivan");
            checkoutCreds.lastName.SendKeys("Ivanov");
            checkoutCreds.zip.SendKeys("123456");

            CheckoutSummary checkoutSummary = checkoutCreds.clickContinue();

            string totalAmount = checkoutSummary.totalAmount.Text.Replace("Total: $", "");

            Assert.That(totalAmount == "97.17");

            CheckoutFinish checkoutFinish = checkoutSummary.clickFinish();

            Assert.That(checkoutFinish.thankYou.Text == "Thank you for your order!");

            AllItems allItems1 = checkoutFinish.clickBack();
        }
    }
}
