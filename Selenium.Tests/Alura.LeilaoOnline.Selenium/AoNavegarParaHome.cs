using Alura.LeilaoOnline.Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace Alura.LeilaoOnline.Selenium
{
    public class AoNavegarParaHome : IDisposable
    {
        private FirefoxDriver driver;

        //Setup
        public AoNavegarParaHome()
        {
            driver = new FirefoxDriver(TesteHelpers.PastaDoExecutavel);
        }

        //TearDown
        public void Dispose()
        {
            driver.Quit();
        }

        [Fact]
        public void DadoFirefoxAbertoDeveMostrarLeiloesNoTitulo()
        {
            //Arrange

            //Act
            driver.Navigate().GoToUrl("http://localhost:5000");

            //Assert
            Assert.Contains("Leilões", driver.Title);
        }

        [Fact]
        public void DadoFirefoxAbertoDeveMostrarProximosLeiloesNaPagina()
        {
            //Arrange

            //Act
            driver.Navigate().GoToUrl("http://localhost:5000");

            //Assert
            Assert.Contains("Próximos Leilões", driver.PageSource);
        }
    }
}
