using TestSeleniumNunit.Framework;
using NUnit.Framework;

namespace TestSeleniumNunit.Tests
{
    public class TestCrearTarea
    {

        public void CrearTarea() 
        {
            var tareaPage = AppPage.getTareaPage();
            tareaPage.OpenPage();
            tareaPage.Login();
            tareaPage.setElements();

            tareaPage.InTarea();

            tareaPage.CreateTarea();
            string titleObtained = tareaPage.GetNameTarea();
            Assert.AreEqual("Ir_al_dentista_mañana", titleObtained, "Resultado esperado invalido");
            
            //tareaPage.OutModal();
            tareaPage.Logout();
            tareaPage.Exit();
        }

    }
}