using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Cryptography;
using Uncorrupted.PageObjects.Login;
using Uncorrupted.PageObjects.Main;

namespace Uncorrupted.Tests
{
    public class LoginPageTests : BaseTest
    {
        [Test]
        public void IncorectUsernameAndPassword()
        {
            string errorMessage = "Epic sadface: Username and password do not match any user in this service";

            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys("DikyBoom");
            loginPage.password.SendKeys("13245768F");
            loginPage.loginButton.Click();
            Assert.That(loginPage.getErrorMessage() == errorMessage);
        }

        [Test]
        public void LockedUser()
        {
            string errorMessage = "Epic sadface: Sorry, this user has been locked out.";

            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys(lockedUserName);
            loginPage.password.SendKeys(password);
            loginPage.loginButton.Click();
            Assert.That(loginPage.getErrorMessage() == errorMessage);
        }

        [Test]
        public void UserNameRequired()
        {
            string errorMessage = "Epic sadface: Username is required";

            LoginPage loginPage = new LoginPage();

            loginPage.password.SendKeys(password);
            loginPage.loginButton.Click();
            Assert.That(loginPage.getErrorMessage() == errorMessage);
        }

        [Test]
        public void PasswrodRequired()
        {
            string errorMessage = "Epic sadface: Password is required";

            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys(goodUserName);
            loginPage.loginButton.Click();
            Assert.That(loginPage.getErrorMessage() == errorMessage);
        }

        [Test]
        public void SuccesfullLogin()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.userName.SendKeys(goodUserName);
            loginPage.password.SendKeys(password);
            loginPage.loginButton.Click();

            MainPage mainPage = new MainPage();

            Assert.That(mainPage.cart.Displayed);
        }
    }
}