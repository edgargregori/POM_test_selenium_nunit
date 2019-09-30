using TestSeleniumNunit.Framework;
using NUnit.Framework;

namespace TestSeleniumNunit.Tests
{
    public class TestBorrarTarea
    {

        public void BorrarTarea() 
        {
            var tareaPage = AppPage.getTareaPage();
            tareaPage.OpenPage();
            tareaPage.Login();
            tareaPage.setElements();

            tareaPage.InTarea();

            tareaPage.CreateTarea();

            tareaPage.DeleteTarea();
            //string titleObtained = tareaPage.GetDeleteNameTarea();
            //Assert.AreEqual("Ir_al_dentista", titleObtained, "Resultado esperado invalido");
            
            tareaPage.Logout();
            tareaPage.Exit();
        }

    }
}