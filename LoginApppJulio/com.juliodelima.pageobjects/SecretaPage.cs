using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LoginApppJulio.com.juliodelima.pageobjects
{
    class SecretaPage
    {

        private IWebDriver driver;

        public SecretaPage (IWebDriver driver)
        {
            this.driver = driver;
        }
        public MePage clicarEmMe()
        {
            driver.FindElement(By.ClassName("me")).Click();

            return new MePage(driver);
        }
    }
}
