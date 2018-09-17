using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoginApppJulio.com.juliodelima.pageobjects
{
    class AddContactPage
    {
        private IWebDriver driver;

        public AddContactPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public AddContactPage escolherTipodeContato(String tipo)
        {

            return this;
        }

        public AddContactPage digitarContato(String contato)
        {

            return this;
        }

        public MePage clicarSalvar()
        {

            return new MePage(driver);
        }

        public MePage adicionarContato(String tipo, String contato)
        {
            escolherTipodeContato(tipo);
            digitarContato(contato);
            clicarSalvar();

            return new MePage(driver);
        }
    }
}
