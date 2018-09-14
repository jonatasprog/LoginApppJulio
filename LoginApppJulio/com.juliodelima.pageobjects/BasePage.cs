using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LoginApppJulio.com.juliodelima.pageobjects
{
    
        public class BasePage
        {
            //protected para as classes filhas poderem utilizar esse atributo, assim a gente mata o problema de ficar repetindo em todas
            public IWebDriver driver;

            public BasePage(IWebDriver driver)
            {
                this.driver = driver;
            }        
        }
}
