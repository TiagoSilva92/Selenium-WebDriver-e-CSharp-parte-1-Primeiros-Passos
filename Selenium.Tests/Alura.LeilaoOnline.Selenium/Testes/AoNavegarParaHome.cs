using Alura.LeilaoOnline.Selenium.Fixtures;
using Alura.LeilaoOnline.Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Firefox Driver")]
    public class AoNavegarParaHome
    {
        private IWebDriver driver;

        //Setup
        public AoNavegarParaHome(TesteFixture fixture)
        {
            driver = fixture.Driver;
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

        [Fact]
        public void DadoFirefoxAbertoFormRegistroNaoDeveMostrarMensagensDeErro()
        {
            //Arrange

            //Act
            driver.Navigate().GoToUrl("http://localhost:5000");

            //Assert
            var form = driver.FindElement(By.TagName("form"));
            var spans = form.FindElements(By.TagName("span"));

            foreach (var span in spans)
            {
                Assert.True(string.IsNullOrEmpty(span.Text));
            }
        }
    }
}
