using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OnlineStore.Extensions;

namespace OnlineStore.PageObjects
{
    public class HomePage
    {
        [FindsBy(How = How.Id, Using ="account")]
        [CacheLookup]
        private IWebElement MyAccount { get; set; }

        public void ClickOnMyAccount()
        {
            MyAccount.ClickOnIt("MyAccount");
        }
    }
}
