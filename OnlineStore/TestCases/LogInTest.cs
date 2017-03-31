using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OnlineStore.PageObjects;

namespace OnlineStore.TestCases
{
    class LogInTest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.store.demoqa.com";
            //driver.Url = "http://store.demoqa.com/products-page/your-account/";

            //driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();

            //driver.FindElement(By.Id("log")).SendKeys("testuser_1");

            //driver.FindElement(By.Id("pwd")).SendKeys("Test@123");

            //driver.FindElement(By.Id("login")).Click();

            //driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Click();

            var homePage = new HomePage(driver);
            homePage.MyAccount.Click();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication();

            driver.Close();
        }
    }
}
