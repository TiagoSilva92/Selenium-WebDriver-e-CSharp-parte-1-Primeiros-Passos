using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace XUnitTestproject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange - dado que um navegador está aberto
            IWebDriver driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            //act - quando navego para a URL caelum
            driver.Navigate().GoToUrl("https://www.caelum.com.br");

            //assertt - então espero que a página apresentada seja a caelum
            Assert.Contains("Caelum", driver.Title);
        }
    }
}
