using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TakeTestExemplo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificaSobreNaTela()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://seed.se.gov.br/");
            driver.Manage().Window.Maximize();
            var sobre = driver.FindElement(By.ClassName("menu__item"));
            sobre.Text.Equals("SECRETARIA");
            driver.Quit();
        }
    }
}