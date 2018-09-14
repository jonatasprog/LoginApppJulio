using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LoginApppJulio.com.juliodelima.pageobjects
{
    class MePage
    {

        private IWebDriver driver;

        public MePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public MePage clicarMoreDataAboutYou()
        {
            driver.FindElement(By.LinkText("MORE DATA ABOUT YOU")).Click();

            return this;
            //pois quando a gente clicar na aba, a gente permanece na mesma pagina
        }

        public AddContactPage clicarNoBotaoAddMoreDataAboutYou()
        {
            driver.FindElement(By.XPath("//button[@data-target=\"addmoredata\"]")).Click();

            return new AddContactPage(driver);

        }
    }
}
