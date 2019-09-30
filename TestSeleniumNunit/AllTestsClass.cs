using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSeleniumNunit.Tests;
using System.Threading;
using NUnit.Framework;

namespace AllTests
{
    [TestClass]
    public class AllTestsClass
    {
        [TestMethod]
        public void AllTestMethod1()
        {
            
            //(new UnitTest1()).TestLogin(); //test 1
            
            (new TestGoToTareaModal()).GoToTareaModal();//test 2
            //Thread.Sleep(5000);
            
             //(new TestCrearTarea()).CrearTarea();// test 3
             //Thread.Sleep(5000);
             //(new TestBorrarTarea()).BorrarTarea();// test 4
             //Thread.Sleep(5000);
             //(new TestEditarTarea()).EditarTarea();// test 5
            
            
            /* 
            var homePage = AppPage.getLoginPage();
            homePage.OpenPage();
            homePage.setElements();
            var panelPage = homePage.Login();
            panelPage.setElements();
            string titleObtained = panelPage.GetTitle();
            NUnit.Framework.Assert.AreEqual("Panel de inicio rápido", titleObtained, "Resultado esperado invalido");
            panelPage.Logout();
            panelPage.Exit();
            */
        }
    }
}
