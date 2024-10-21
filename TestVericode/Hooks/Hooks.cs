using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Drawing;

namespace TestVericode.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeFeature()]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            //Cria o webdriver no conceito de feature, dessa forma consigo executar mais de um cenário no mesmo driver
            IWebDriver driver = new ChromeDriver();            
            featureContext.Set(driver);
            driver.Manage().Window.Position = new Point(2000, 0);
            driver.Manage().Window.Maximize();

        }

        [AfterFeature]
        public static void AfterFeature(FeatureContext featureContext)
        {
            // Limpa o driver do browser
            var webDriver = featureContext.Get<IWebDriver>();
            webDriver.Quit();
            webDriver.Dispose();
        }


        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario(FeatureContext featureContext)
        {
            Console.WriteLine("Running before scenario...");
            var driver = featureContext.Get<IWebDriver>();
            _container.RegisterInstanceAs<IWebDriver>(driver);
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }



    }
}