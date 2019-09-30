using System;
using TestSeleniumNunit.Framework;
using NUnit.Framework;

namespace TestSeleniumNunit.Tests
{
    //[TestFixture]
    public class UnitTest1
    {
        //[Test (Description ="Login successful")]
        public void TestLogin()
        {
            ///* 
            var homePage = AppPage.getLoginPage();
            homePage.OpenPage();
            homePage.setElements();
            var panelPage = homePage.Login();
            panelPage.setElements();
            string titleObtained = panelPage.GetTitle();
            Assert.AreEqual("Panel de inicio rápido", titleObtained, "Resultado esperado invalido");
            panelPage.Logout();
            panelPage.Exit();
            //*/

        }
    }
}
