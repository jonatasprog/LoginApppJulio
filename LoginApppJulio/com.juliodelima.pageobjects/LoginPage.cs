using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using LoginApppJulio.com.juliodelima.testcases;

namespace LoginApppJulio.com.juliodelima.pageobjects
{
    class LoginPage
    {

        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public LoginFormPage clickSignIn()
        {
            //usar a instancia do navegador para clicar no botao SignIn
            //link que possui o texto "Sign in"
            driver.FindElement(By.LinkText("Sign in")).Click();


            //O retorno é uma instância da próxima página.
            return new LoginFormPage(driver);
            //vou passar o navegador!
            //ou seja, eu sei que lá tem um construtor também que está esperando um navegador
        }
    }
}
