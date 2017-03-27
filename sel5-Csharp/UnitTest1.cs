using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace sel5_Csharp
{
    [TestClass]
    public class MyFirstTest 
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void start() {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }//public void start

        [Test]
        public void FirstTest() {
            driver.Url = "http://www.google.com";
            driver.FindElement(By.Name("q")).SendKeys("webdriver");
            driver.FindElement(By.Name("btnG")).Click();
            wait.Until(ExpectedConditions.TitleIs("webdriver - Google Search"));
        }//public void FirstTest

        [TearDown]
        public void stop() {
            driver.Quit();
            driver = null;
        }//public void stop

    }
}
