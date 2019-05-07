using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAdvanced.BO;
using SeleniumAdvanced.BusinessFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [Test]
        public void LoginTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:3030/admin";

            User user = TestUsersGenerator.GenerateValidUser();
            LoginFunctions loginFunc = new LoginFunctions(driver);

            loginFunc.Login(user);


            LoginPage loginPage = new LoginPage(driver);
            Assert.IsTrue(loginPage.isLoginPerformedSuccessfully(), "Login failed");

            

        }
    }
}
