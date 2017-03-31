using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OnlineStore.PageObjects;
using System.Configuration;

namespace OnlineStore.TestCases
{
    class LogInTest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = ConfigurationManager.AppSettings["URL"];

            var homePage = new HomePage(driver);
            homePage.ClickOnMyAccount();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication();

            driver.Close();
        }
    }
}
