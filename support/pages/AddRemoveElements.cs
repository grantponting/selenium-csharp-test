using OpenQA.Selenium;
using BaseTest;

namespace AddRemoveElementsPage
{
    public class AddRemoveElements
    {
        IWebDriver driver;
        public AddRemoveElements(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        public void visit()
        {
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/add_remove_elements/");
        }

        public IWebElement getAddElementButton()
        {
            return driver.FindElement(By.CssSelector("button[onclick='addElement()']"));
        }
    }
}