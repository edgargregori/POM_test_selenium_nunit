using TestSeleniumNunit.Framework;
using NUnit.Framework;

namespace TestSeleniumNunit.Tests
{
    public class TestEditarTarea
    {

        public void EditarTarea() 
        {
            var tareaPage = AppPage.getTareaPage();
            tareaPage.OpenPage();
            tareaPage.Login();
            tareaPage.setElements();

            tareaPage.InTarea();

            tareaPage.CreateTarea();

            tareaPage.UpdateTarea();
            string titleObtained = tareaPage.GetUpdateNameTarea();
            Assert.AreEqual("Ir_al_dentista_hoy", titleObtained, "Resultado esperado invalido");
            
            //tareaPage.OutModal();
            tareaPage.Logout();
            tareaPage.Exit();
        }

    }
}