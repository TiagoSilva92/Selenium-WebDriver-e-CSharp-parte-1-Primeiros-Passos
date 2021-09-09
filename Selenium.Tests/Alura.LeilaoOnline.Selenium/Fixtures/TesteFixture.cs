using Alura.LeilaoOnline.Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.LeilaoOnline.Selenium.Fixtures
{
    public class TesteFixture : IDisposable
    {
        public IWebDriver Driver { get; set; }

        //Setup
        public TesteFixture()
        {
            Driver = new FirefoxDriver(TesteHelpers.PastaDoExecutavel);
        }

        //TearDown
        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
