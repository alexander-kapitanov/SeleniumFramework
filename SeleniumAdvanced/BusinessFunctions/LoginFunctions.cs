using OpenQA.Selenium;
using SeleniumAdvanced.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced.BusinessFunctions
{
    class LoginFunctions
    {
        public IWebDriver driver;

        public LoginFunctions(IWebDriver driver)
        {
            this.driver = driver;
        }
 
        public void Login(User user)
        {
            new LoginPage(driver).Login(user.getLogin(), user.getPassword());
        }
    }
}
