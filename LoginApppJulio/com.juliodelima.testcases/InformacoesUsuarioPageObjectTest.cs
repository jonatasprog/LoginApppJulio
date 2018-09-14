using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using LoginApppJulio.com.juliodelima.pageobjects;
using LoginApppJulio.com.juliodelima.suport;

namespace LoginApppJulio.com.juliodelima.testcases
{
    [TestFixture]
    class InformacoesUsuarioPageObjectTest
    {        
        IWebDriver driver = new ChromeDriver(@"C:\Users\jonat\drivers\");

        public InformacoesUsuarioPageObjectTest()
        {

            //driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("http://www.juliodelima.com.br/taskit");
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void testAdicionarUmaInformacaoAdicionalDoUsuario()
        {
            new LoginPage(driver)
               .clickSignIn()
               .fazerLogin("julio0001", "123456")
               .clicarEmMe()
               .clicarMoreDataAboutYou()
               .clicarNoBotaoAddMoreDataAboutYou();

        }
            /*package tests;
    import org.junit.After;
    import org.junit.Before;
    import org.junit.Test;
    import org.openqa.selenium.WebDriver;
    import pages.LoginPage;
    import suporte.Web;

    //uma repetição dos nossos testes-6 de forma não estruturada
    public class InformacoesUsuarioPageObjectsTest{

        private WebDriver navegador;

        @Before
        public void setUp(){
            navegador = Web.createChrome();
            //pegando uma instancia do chrome
        }

        @Test
        public void testAdicionarUmaInformacaoAdicionalDoUsuario(){
            //aqui ele sabe que eu vou entrando nas classes pra usar os metodos, a partir da primeira
            new LoginPage(navegador)
                    .clickSignIn()
                    .fazerLogin("julio0001","123456")
                    .clicarEmMe()
                    .clicarMoreDataAboutYou()
                    .clicarNoBotaoAddMoreDataAboutYou();

                    /*.digitarLogin("julio0001")
                    .digitarSenha("123456")
                    .clicarSignIn();
            //na abordagem funcional eliminaria essas 3 chamadas e coloca .fazerLogin("julio0001","123456");
        }

        @After
        public void tearDown()
        {
            // navegador.quit();
            //fechando a instancia do chrome
        }

    }*/
        }
}
