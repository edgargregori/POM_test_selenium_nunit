using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumNunit.Framework
{
    class AppDriver
    {
        public const String FIREFOX = "Firefox";
        public const String CHROME = "Chrome";

        private IWebDriver _driver;
        private static AppDriver _Instance;

        public AppDriver()
        {

        }

        /// <summary>Method to obtain the instance of object AppDriver </summary>
        public static AppDriver GetInstance()
        {
            if ((_Instance == null))
            {
                _Instance = new AppDriver();
            }

            return _Instance;
        }

        /// <summary> Method to obtain get the driver</summary>
        public IWebDriver GetDriver()
        {
            if ((this._driver == null))
            {

                switch (CHROME)
                {

                    case FIREFOX:
                        //this._driver = new FirefoxDriver();
                        //break;
                    case CHROME:
                        this._driver = new ChromeDriver("/home/eg/Workspace_vscode/POM_test_selenium_nunit/TestSeleniumNunit/bin/Debug/netcoreapp2.2/");
                        break;

                }
            }

            return this._driver;
        }

    }
}
