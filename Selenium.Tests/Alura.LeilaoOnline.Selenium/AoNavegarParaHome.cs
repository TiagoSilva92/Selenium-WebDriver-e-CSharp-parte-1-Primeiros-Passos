using Alura.LeilaoOnline.Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace Alura.LeilaoOnline.Selenium
{
    public class AoNavegarParaHome
    {
        [Fact]
        public void DadoFirefoxAbertoDeveMostrarLeiloesNoTitulo()
        {
            //Arrange
            IWebDriver driver = new FirefoxDriver(TesteHelpers.PastaDoExecutavel);

            //act
            driver.Navigate().GoToUrl("http://localhost:5000");

            //Assert
            Assert.Contains("Leilões", driver.Title);

        }

        [Fact]
        public void DadoFirefoxAbertoDeveMostrarProximosLeiloesNaPagina()
        {
            //Arrange
            IWebDriver driver = new FirefoxDriver(TesteHelpers.PastaDoExecutavel);

            //Act
            driver.Navigate().GoToUrl("http://localhost:5000");

            //Assert
            Assert.Contains("Próximos Leilões", driver.PageSource);

        }
    }
}
