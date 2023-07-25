using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uncorrupted.PageObjects.Main;

namespace Uncorrupted.PageObjects.Login
{
    public class LoginPage
    {
        public IWebElement userName;
        public IWebElement password;
        public IWebElement loginButton;

        public LoginPage() {
            userName = driver.FindElement(By.Id("user-name"));
            password = driver.FindElement(By.Id("password"));
            loginButton = driver.FindElement(By.Id("login-button"));
        }

        public string getErrorMessage() => driver.FindElement(By.CssSelector("*[data-test=\"error\"]")).Text;
    }
}