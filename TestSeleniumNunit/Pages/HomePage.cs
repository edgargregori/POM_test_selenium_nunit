using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumNunit.Framework;

namespace TestSeleniumNunit.Pages
{
    class HomePage
    {
        private IWebDriver driver;
        By loginUserLocator = By.Id("login_usu");
        By loginPassLocator = By.Id("login_pass");
        By loginUserBtnLocator = By.Id("login_user_btn");

        public PanelPage Login()
        {
            userTxt.SendKeys("joooelr");
            passwordTxt.SendKeys("Control123");
            passwordTxt.SendKeys(Keys.Enter);
            var panelPage = AppPage.getPanelPage();
            return panelPage;
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl("https://www.notasonline.es/");
        }
        public IWebElement userTxt { get; set; }
        public IWebElement passwordTxt { get; set; }
        public IWebElement loginBtn { get; set; }
        public HomePage() {
            this.driver = AppDriver.GetInstance().GetDriver();
        }
        public void setElements() {
            userTxt = driver.FindElement(loginUserLocator);
            passwordTxt = driver.FindElement(loginPassLocator);
            loginBtn = driver.FindElement(loginUserBtnLocator);
        }

    }
}
