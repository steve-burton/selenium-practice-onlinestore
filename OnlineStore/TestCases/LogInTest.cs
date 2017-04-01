using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OnlineStore.PageObjects;
using OnlineStore.WrapperFactory;
using System.Configuration;

namespace OnlineStore.TestCases
{
    class LogInTest
    {
        private IWebDriver driver;

        [Test]
        public void Test()
        {
            // This is the old test without BrowserFactory
            //IWebDriver driver = new FirefoxDriver();
            //driver.Url = ConfigurationManager.AppSettings["URL"];

            //var homePage = new HomePage(driver);
            //homePage.ClickOnMyAccount();

            //var loginPage = new LoginPage(driver);
            //loginPage.LoginToApplication();

            //driver.Close();

            BrowserFactory.InitBrowser("Firefox");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);

            Page.Home.ClickOnMyAccount();
            Page.Login.LoginToApplication();

            BrowserFactory.CloseAllDrivers();
        }
    }
}
