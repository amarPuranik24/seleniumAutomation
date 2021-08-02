using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //verify fb link on crawford uk page.
        public void TestCase1()
        {
            //using chrome driver
           IWebDriver driver = new ChromeDriver("C:\\Users\\amar_puranik\\source\\repos\\UnitTestProject1\\UnitTestProject1\\Driver");
           ChromeOptions c = new ChromeOptions();
           c.PageLoadStrategy = PageLoadStrategy.Normal;
            //adding implicit wait
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //navigating to required URL
           driver.Url = "http://www.crawco.co.uk";
           driver.Manage().Window.Maximize();
            //assert if facebook url is displayed on page.
           Assert.IsTrue(driver.FindElement(By.XPath("//a[@href='https://www.facebook.com/crawfordandco']")).Displayed);
            driver.Quit(); 
        }
    }
}
