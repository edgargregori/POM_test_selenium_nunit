using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestSeleniumNunit.Framework;

namespace TestSeleniumNunit.Pages
{
    class PanelPage
    {
        private IWebDriver driver;
        By titleLocator = By.CssSelector("h1");
        By userNameBtnLocator = By.XPath("//span[contains(@class,'username')]");
        By salirBtnLocator = By.XPath("//a[contains(@href,'salir')]");
        public IWebElement userNameBtn { get; set; }
        public IWebElement salirBtn { get; set; }
        public IWebElement title { get; set; }
        public PanelPage()
        {
            this.driver = AppDriver.GetInstance().GetDriver();
        }

        internal void Exit()
        {
            driver.Quit();
        }

        internal void Logout()
        {
            userNameBtn.Click();
            userNameBtn.Click();
            salirBtn.Click();
        }

        internal string GetTitle()
        {
            var obtainedTitle = title.Text;
            return obtainedTitle;
        }

        public void setElements()
        {
            Thread.Sleep(9000);
            userNameBtn = driver.FindElement(userNameBtnLocator);
            salirBtn = driver.FindElement(salirBtnLocator);           
            title = driver.FindElement(titleLocator);
        }

    }
}
