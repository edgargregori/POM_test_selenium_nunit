using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumNunit.Pages;

namespace TestSeleniumNunit.Framework
{
    class AppPage
    {
        
            private static HomePage loginPage;
            private static PanelPage panelPage;
            private static TareaPage tareaPage;
            public AppPage()
            {

            }

            public static HomePage getLoginPage()
            {
                if (loginPage == null)
                {
                    loginPage = new HomePage();
                }
                return loginPage;
            }
            public static PanelPage getPanelPage()
            {
                if (panelPage == null)
                {
                    panelPage = new PanelPage();
                }
                return panelPage;
            }

            public static TareaPage getTareaPage()
            {
                if (tareaPage == null)
                {
                    tareaPage = new TareaPage();
                }
                return tareaPage;
            }
    }
}
