using NUnit.Framework;
using BaseTest;
using OpenQA.Selenium;
using AddRemoveElementsPage;

namespace AddRemoveElementsTests
{
    public class AddRemoveElementsTests : BaseTest.BaseTest
    {
        AddRemoveElements addRemoveElementPage;

        [SetUp]
        public void pageInit()
        {
            addRemoveElementPage = new AddRemoveElements(driver);
        }

        [Test]
        public void addElement()
        {
            addRemoveElementPage.visit();
            Assert.IsTrue(addRemoveElementPage.getAddElementButton().Displayed);
        }
    }
}