using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LoginApppJulio.com.juliodelima.pageobjects
{
    class LoginFormPage
    {
        private IWebDriver driver;

        public LoginFormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LoginFormPage digitarLogin(String login) {
        driver.FindElement(By.Id("signinbox")).FindElement(By.Name("login")).SendKeys(login);
        //ou seja, esses metodos de ação devem retornar uma outra página, ou ela mesma como vemos abaixo... ainda permanece na página
        return this;
    }
    //depois que eu digito o login pra que pagina eu vou? ^ FICO NA MESMA PÁGINA! ENTAO VOU RETORNAR A MESMA PAGINA ONDE EU ESTOU!

    public LoginFormPage digitarSenha(String password) {
        driver.FindElement(By.Id("signinbox")).FindElement(By.Name("password")).SendKeys(password);

        return this;
    }

    public SecretaPage clicarSignIn() {
        driver.FindElement(By.LinkText("SIGN IN")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10.00);

            return new SecretaPage(driver);

    }
//acima abordagem ESTRUTURAL, abaixo ABORDAGEM FUNCIONAL.  O MELHOR É ESTRUTURAL quando nao preciso conferir mensagens de erro e tal
    /*public SecretaPage fazerLogin(String login, String password){
        navegador.findElement(By.id("signinbox")).findElement(By.name("login")).sendKeys(login);
        navegador.findElement(By.id("signinbox")).findElement(By.name("password")).sendKeys(password);
        navegador.findElement(By.linkText("SIGN IN")).click();

        return new SecretaPage(navegador);
    }*/

        //usar estruturais dentro de um funcional: BOA AOBORDAGEM
        public SecretaPage fazerLogin(String login, String password)
        {
            digitarLogin(login);
            digitarSenha(password);
            clicarSignIn();

            return new SecretaPage(driver);
        }
    }
}
