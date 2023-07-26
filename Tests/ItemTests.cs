using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uncorrupted.PageObjects.Login;
using Uncorrupted.PageObjects.Main;

namespace Uncorrupted.Tests
{
    public class ItemTests : BaseTest
    {
        [Test]
        public void correctInfoOfItem()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys(goodUserName);
            loginPage.password.SendKeys(password);
            AllItems allItems = loginPage.clickContinueWithCorrectData();

            Item backPackPage = allItems.clickOnBackPackLink();

            Assert.That(backPackPage.itemName.Text == "Sauce Labs Backpack");
            Assert.That(backPackPage.itemPrice.Text == "$29.99");
            Assert.That(backPackPage.itemDescription.Text == "carry.allTheThings() with the sleek, streamlined Sly Pack that " +
                "melds uncompromising style with unequaled laptop and tablet protection.");
            Assert.That(backPackPage.itemImage.GetAttribute("alt") == "Sauce Labs Backpack");
        }
    }
}
