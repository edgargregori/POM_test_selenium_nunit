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
    
    class TareaPage
    {
        private IWebDriver driver;
        By loginUserLocator = By.Id("login_usu");
        By loginPassLocator = By.Id("login_pass");
        By loginUserBtnLocator = By.Id("login_user_btn");
        By tareaBtnLocator = By.Id("modal_add_tarea_rap_btn");
        By tareaModalLocator = By.Id("modal_add_tarea_rap");
        By titleLocator = By.CssSelector("h4");
        By userNameBtnLocator = By.XPath("//span[contains(@class,'username')]");
        By salirBtnLocator = By.XPath("//a[contains(@href,'salir')]");
        By nameTareaLabelLocator = By.Id("label_tarea_rap");
        By nameEditTareaLocator = By.Id("label_edit_tarea_rap");
        By priorityTareaLocator = By.Id("select_tarea_rap");
        By crearTareaBtnLocator = By.Id("add_tarea_rap");
        By spanTextLocator = By.XPath("//span[contains(@class,'desc')]");
        By borrarBtnLocator = By.XPath("//button[contains(@class,'btn btn-danger btn-xs del_task')]");
        By eliminarBtnLocator = By.Id("del_tarea_rap");
        By irAlPanelTareasRapidasLocator = By.Id("panel_tareas_rapidas");
        By expandirTareasLocator = By.XPath("//a[contains(@class,'btn btn-xs btn-link panel-collapse expand')]");
        By editarTareasLocator = By.XPath("//button[contains(@class,'btn btn-success btn-xs edit_task')]");
        By selecionarInputTareaLocator = By.Id("select_edit_tarea_rap");
        By guardarCambiosInputTareaLocator = By.Id("add_edit_tarea_rap");
        By spanEditTextLocator = By.XPath("//span[contains(@class,'desc')]"); 
        public IWebElement userTxt { get; set; }
        public IWebElement passwordTxt { get; set; }
        public IWebElement loginBtn { get; set; }
        public IWebElement tareaBtn { get; set; }
        public IWebElement tareaModal { get; set; }
        public IWebElement userNameBtn { get; set; }
        public IWebElement salirBtn { get; set; }
        public IWebElement title { get; set; }
        public IWebElement nameTarea { get; set; }
        public IWebElement priorityTarea { get; set; }
        public IWebElement crearTareaBtn { get; set; }
        public IWebElement spanText { get; set; }
        public IWebElement borrarBtn { get; set; }
        public IWebElement eliminarBtn { get; set; }
        public IWebElement irAlPanelTareasRapidas { get; set; }
        public IWebElement expandirTareas { get; set; }
        public IWebElement editarTareas { get; set; }
        public IWebElement selecionarInputTarea { get; set; }
        public IWebElement guardarCambiosInputTarea { get; set; }
        public IWebElement nameEditTarea { get; set; }
        public IWebElement spanEditText { get; set; }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl("https://www.notasonline.es/");
        }
        public TareaPage(){
            this.driver = AppDriver.GetInstance().GetDriver();
        }
        public void Login()
        {
            userTxt = driver.FindElement(loginUserLocator);
            passwordTxt = driver.FindElement(loginPassLocator);
            loginBtn = driver.FindElement(loginUserBtnLocator);

            userTxt.SendKeys("edgar_gregori");
            passwordTxt.SendKeys("greg9759");
            passwordTxt.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }
        public void setElements() {
            
             Thread.Sleep(7000);
            userNameBtn = driver.FindElement(userNameBtnLocator);
            salirBtn = driver.FindElement(salirBtnLocator);           
            title = driver.FindElement(titleLocator);
            tareaBtn = driver.FindElement(tareaBtnLocator);
        
        }
        internal void Exit()
        {
            driver.Quit();
        }

        internal void Logout()
        {
            Thread.Sleep(5000);
            userNameBtn.Click();
            userNameBtn.Click();
            salirBtn.Click();
        }

        internal string GetTitle()
        {
            var obtainedTitle = title.Text;
            return obtainedTitle;
        }
        internal string GetTitleModal()
        {
            var obtainedTitleModal = tareaModal.Text;
            return obtainedTitleModal;
        }
        internal void InTarea()
        {
            Thread.Sleep(2000);
            tareaBtn.Click();
            Thread.Sleep(2000);
            tareaModal = driver.FindElement(tareaModalLocator);
            nameTarea = driver.FindElement(nameTareaLabelLocator);
            priorityTarea = driver.FindElement(priorityTareaLocator);
            crearTareaBtn = driver.FindElement(crearTareaBtnLocator);
        }
        internal void OutModal()
        {
            Thread.Sleep(2000);
            tareaModal.SendKeys(Keys.Escape);
        }
        
        internal void CreateTarea()
        {
            nameTarea.SendKeys("Ir_al_dentista_mañana");
            Thread.Sleep(2000);
            priorityTarea.Click();
            priorityTarea.SendKeys("m");
            priorityTarea.SendKeys(Keys.Enter);
            crearTareaBtn.Click();
            Thread.Sleep(1000);
            //tareaModal.Click();
        }
        internal void DeleteTarea()
        {

            Thread.Sleep(1000);
 
            borrarBtn = driver.FindElement(borrarBtnLocator);
            borrarBtn.Click();
            Thread.Sleep(2000);
            eliminarBtn = driver.FindElement(eliminarBtnLocator);
            eliminarBtn.Click();
            Thread.Sleep(1000);
        }
        internal void UpdateTarea()
        {
            editarTareas = driver.FindElement(editarTareasLocator);
            editarTareas.Click();
            Thread.Sleep(1000);
            
            nameEditTarea = driver.FindElement(nameEditTareaLocator);
            nameEditTarea.Click();
            for (int i = 0; i < 6; i++)
            {
                nameEditTarea.SendKeys(Keys.Backspace);
            }
            nameEditTarea.SendKeys("hoy");
            
            selecionarInputTarea = driver.FindElement(selecionarInputTareaLocator);
            selecionarInputTarea.Click();
            selecionarInputTarea.SendKeys("h");
            selecionarInputTarea.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            guardarCambiosInputTarea = driver.FindElement(guardarCambiosInputTareaLocator);
            guardarCambiosInputTarea.Click();
            Thread.Sleep(1000);

        }
        internal string GetUpdateNameTarea()
        {
            spanEditText = driver.FindElement(spanEditTextLocator);
            var obtainedSpanEditText = spanEditText.Text;
            return obtainedSpanEditText;
        }
        internal string GetNameTarea()
        {
            spanText = driver.FindElement(spanTextLocator);
            var obtainedSpanText = spanText.Text;
            return obtainedSpanText;
        }
        
    }
}