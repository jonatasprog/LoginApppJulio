using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoginApppJulio.com.juliodelima.suport
{
   public class Web
    {
        public static IWebDriver createChrome()
        {
            // Abrindo o navegador
            IWebDriver navegador = new ChromeDriver(@"C:\Users\jonat\drivers\");
            // navegador.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            navegador.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10.00);

            // Navegando para a página do Taskit!
            navegador.Navigate().GoToUrl("http://www.juliodelima.com.br/taskit");
            navegador.Manage().Window.Maximize();

            return navegador;
        }
    }
}
