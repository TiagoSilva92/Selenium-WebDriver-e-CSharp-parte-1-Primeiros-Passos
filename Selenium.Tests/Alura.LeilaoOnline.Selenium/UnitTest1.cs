using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace Alura.LeilaoOnline.Selenium
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            IWebDriver driver = new FirefoxDriver(
                Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location)
            );

            //act
            driver.Navigate().GoToUrl("http://localhost:5000");

            //assert
            Assert.Contains("Leilões", driver.Title);

        }
    }
}
