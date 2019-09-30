using TestSeleniumNunit.Framework;
using NUnit.Framework;

namespace TestSeleniumNunit.Tests
{

    public class TestGoToTareaModal
    {

        public void GoToTareaModal() 
        {
            var tareaPage = AppPage.getTareaPage();
            tareaPage.OpenPage();
            tareaPage.Login();
            tareaPage.setElements();
            
            tareaPage.InTarea();
            string titleObtained = tareaPage.GetTitle();
            //string titleObtainModal = tareaPage.GetTitleModal();

            Assert.AreEqual("Añadir nueva tarea", titleObtained, "Resultado esperado invalido");
            tareaPage.OutModal();
            
            tareaPage.Logout();
            tareaPage.Exit();
        }

    }
}