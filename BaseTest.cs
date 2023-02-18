using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Environments;

namespace BaseTest
{
    public class BaseTest
    {
        protected IWebDriver? driver;
        protected string[]? adminAccount;
        protected string[]? userAccount;

        [OneTimeSetUp]
        public void setUp()
        {
            EnvironmentVariables env = new EnvironmentVariables();
            driver = env.getDriver();
            adminAccount = env.getAdminAccount();
            userAccount = env.getUserAccount();
        }

        [OneTimeTearDown]
        public void tearDown()
        {
            driver.Close();
        }
    }
}