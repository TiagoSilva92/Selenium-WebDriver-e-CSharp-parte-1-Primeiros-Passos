using Alura.LeilaoOnline.Selenium.Fixtures;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Firefox Driver")]
    public class AoEfetuarRegistro
    {
        private IWebDriver driver;

        public AoEfetuarRegistro(TesteFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void DadoInfoValidasDeveIrParaPaginaDeAgradecimento()
        {
            //Arranje - dado firefox aberto, pagina inicial do sistema de leilões
            // dados de registro válidos informados 
            driver.Navigate().GoToUrl("http://localhost:5000");

            //nome
            var inputNome = driver.FindElement(By.Id("Nome"));
            //email
            var inputEmail = driver.FindElement(By.Id("Email"));
            //password
            var inputSenha = driver.FindElement(By.Id("Password"));
            //confirmpassword
            var inputConfirmaSenha = driver.FindElement(By.Id("ConfirmPassword"));
            //botão de registo
            var botaoRegistro = driver.FindElement(By.Id("btnRegistro"));

            inputNome.SendKeys("Tiago da Silva Melo");
            inputEmail.SendKeys("tiagodasilva360@hotmail.com");
            inputSenha.SendKeys("123");
            inputConfirmaSenha.SendKeys("123");

            //Act - efetuo o registro
            botaoRegistro.Click();

            //Assert -  devo ser direcionado para uma páginma de agradecimento
            Assert.Contains("Obrigado", driver.PageSource);
        }

        [Theory]
        [InlineData("", "tiagosilva360@hotmail.com", "123" ,"123")]
        [InlineData("Tiago Silva", "tiago", "123", "123")]
        [InlineData("Tiago", "tiagosilva360@hotmail.com", "123", "456")]
        [InlineData("Tiago", "tiagosilva360@hotmail.com", "123", "")]
        public void DadoInfoInvalidasDeveContinuarNaHome(
            string nome,
            string email,
            string senha, 
            string confirmaSenha)
        {
            //Arranje - dado firefox aberto, pagina inicial do sistema de leilões
            // dados de registro válidos informados 
            driver.Navigate().GoToUrl("http://localhost:5000");

            //nome
            var inputNome = driver.FindElement(By.Id("Nome"));
            //email
            var inputEmail = driver.FindElement(By.Id("Email"));
            //password
            var inputSenha = driver.FindElement(By.Id("Password"));
            //confirmpassword
            var inputConfirmaSenha = driver.FindElement(By.Id("ConfirmPassword"));
            //botão de registo
            var botaoRegistro = driver.FindElement(By.Id("btnRegistro"));

            inputNome.SendKeys(nome);
            inputEmail.SendKeys(email);
            inputSenha.SendKeys(senha);
            inputConfirmaSenha.SendKeys(confirmaSenha);

            //Act - efetuo o registro
            botaoRegistro.Click();

            //Assert -  devo ser direcionado para uma páginma de agradecimento
            Assert.Contains("section-registro", driver.PageSource);
        }
    }
}
