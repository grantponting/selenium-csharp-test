using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Environments
{
    public class EnvironmentVariables
    {
        string? browser = Environment.GetEnvironmentVariable("BROWSER");
        string? env = Environment.GetEnvironmentVariable("ENV");

        public IWebDriver getDriver()
        {
            IWebDriver driver;
            if (browser == null)
            {
                browser = "chrome";
            }

            switch (browser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                default:
                    throw new Exception("Invalid browser type or not a supported browser");
            }
            return driver;
        }

        public string[] getAdminAccount()
        {
            string[]? account;
            if (env == null)
            {
                env = "qa";
            }

            switch (env.ToLower())
            {
                case "qa":
                    account = new string[] { "admin", "admin" };
                    break;
                case "prod":
                    account = new string[] { "adminProd", "adminProd" };
                    break;
                default:
                    account = new string[] { "admin", "admin" };
                    break;
            }
            return account;
        }

        public string[] getUserAccount()
        {
            string[]? account;
            if (env == null)
            {
                env = "qa";
            }

            switch (env.ToLower())
            {
                case "qa":
                    account = new string[] { "user", "user" };
                    break;
                case "prod":
                    account = new string[] { "userProd", "userProd" };
                    break;
                default:
                    account = new string[] { "user", "user" };
                    break;
            }
            return account;
        }
    }
}