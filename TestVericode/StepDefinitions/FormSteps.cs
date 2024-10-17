using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestVericode.Support;
using System.Drawing;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;
using System.Diagnostics.Metrics;

namespace TestVericode.StepDefinitions
{
    [Binding]
    public class FormSteps : Reports
    {

        static IWebDriver driver { get; set; }
        //TODO - adicionar o openbrowser no utility
        [Given(@"que eu acesso o site '(.*)'")]
        public void GivenQueEuAcessoOSite(string site)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Position = new Point(2000, 0);
            driver.Manage().Window.Maximize();

            driver.Url = site;
            //Validação do título da página
            Assert.Equal("Enter Vehicle Data", driver.Title);
            addScreenShot(driver, "Cenario 01");

        }

        //início dos metodos utilizados no BDD(SPECFLOW)
        [Given(@"clico na opcao Automobile")]
        public void GivenEuValidoQueEstouNaPaginaEnterVehicleData()
        {
            IWebElement element = driver.FindElement(By.Id("nav_automobile"));
            element.Click();
            Thread.Sleep(2000);
        }


        [Given(@"seleciono a opcao '(.*)'")]
        public void GivenSelecionoAOpcaoHonda(string marca)
        {

            new SelectElement(driver.FindElement(By.Id("make"))).SelectByText(marca);
            Thread.Sleep(2000);

        }


        [Given(@"digito no campo Engine Performance o valor '(.*)'")]
        public void GivenDigitoNoCampoEnginePerformanceOValor(string kw)
        {
            IWebElement element = driver.FindElement(By.Id("engineperformance"));
            element.SendKeys(kw);
            Thread.Sleep(2000);
        }

        [Given(@"digito no campo Date of Manufacture '(.*)'")]
        public void GivenDigitoNoCampoDateOfManufacture(string data)
        {
            IWebElement element = driver.FindElement(By.Id("dateofmanufacture"));
            element.SendKeys(data);
            Thread.Sleep(2000);
        }

        [Given(@"seleciono a opcao '(.*)' no campo Number of Seat")]
        public void GivenSelecionoAOpcaoNoCampoNumberOfSeat(string seats)
        {
            new SelectElement(driver.FindElement(By.Id("numberofseats"))).SelectByText(seats);
            Thread.Sleep(2000);
        }

        [Given(@"seleciono a opcao '(.*)' no campo Fuel Type")]
        public void GivenSelecionoAOpcaoPetrolNoCampoFuelType(string fuel)
        {
            new SelectElement(driver.FindElement(By.Id("fuel"))).SelectByText(fuel);
            Thread.Sleep(2000);
        }

        [Given(@"digito no campo List Price o valor '(.*)'")]
        public void GivenDigitoNoCampoListPriceOValor(string listPrice)
        {
            IWebElement element = driver.FindElement(By.Id("listprice"));
            element.SendKeys(listPrice);
            Thread.Sleep(2000);
        }

        [Given(@"digito no campo Annual Mileage o valor '(.*)'")]
        public void GivenDigitoNoCampoAnnualMileageOValor(string annualmileage)
        {
            IWebElement element = driver.FindElement(By.Id("annualmileage"));
            element.SendKeys(annualmileage);
            Thread.Sleep(2000);
            addScreenShot(driver, "Cenario 01 complete");
        }

        [When(@"clico no botao Next")]
        public void WhenClicoNoBotaoNext()
        {
            IWebElement element = driver.FindElement(By.Id("nextenterinsurantdata"));
            element.Click();
            Thread.Sleep(2000);
        }

        [Then(@"sou redirecionado pra aba Enter Insurant Data")]
        public void ThenSouRedirecionadoPraAbaEnterInsurantData()
        {
            addScreenShot(driver, "Cenario 01 aba Insurant Data");
        }

        //Steps formulário Enter Insurant Data

        [Given(@"que eu estou na aba Enter Insurant Data")]
        public void GivenQueEuEstouNaAbaEnterInsurantData()
        {
            Assert.Equal("Enter Insurant Data", driver.Title);
            addScreenShot(driver, "Cenario 02");
        }

        [Given(@"digito no campo First Name o nome '(.*)'")]
        public void GivenDigitoNoCampoFirstNameONome(string firstname)
        {

            IWebElement element = driver.FindElement(By.Id("firstname"));
            element.SendKeys(firstname);
            Thread.Sleep(2000);
        }

        [Given(@"digito no campo Last Name o sobrenome '(.*)'")]
        public void GivenDigitoNoCampoLastNameOSobrenome(string lastname)
        {
            IWebElement element = driver.FindElement(By.Id("lastname"));
            element.SendKeys(lastname);
            Thread.Sleep(2000);
        }

        [Given(@"digito no campo Date of Birth a data '(.*)'")]
        public void GivenDigitoNoCampoDateOfBirthAData(string birthdata)
        {
            IWebElement element = driver.FindElement(By.Id("birthdate"));
            element.SendKeys(birthdata);
            Thread.Sleep(2000);
        }

        [Given(@"clico na opcao '(.*)' no campo Gender")]
        public void GivenClicoNaOpcaoMaleNoCampoGender(string gender)
        {
            IWebElement element = driver.FindElement(By.XPath("//label[@class='ideal-radiocheck-label'][contains(.,'" + gender + "')]"));
            element.Click();
            Thread.Sleep(2000);
        }

        [Given(@"seleciono a opcao '(.*)' no campo Country")]
        public void GivenSelecionoAOpcaoBrazilNoCampoCountry(string country)
        {
            new SelectElement(driver.FindElement(By.Id("country"))).SelectByText(country);
            Thread.Sleep(2000);
        }

        [Given(@"digito no campo Zip Code o cep '(.*)'")]
        public void GivenDigitoNoCampoZipCodeOCep(string zipcode)
        {
            IWebElement element = driver.FindElement(By.Id("zipcode"));
            element.SendKeys(zipcode);
            Thread.Sleep(2000);
        }

        [Given(@"no campo City digito '(.*)'")]
        public void GivenNoCampoCityDigito(string cityname)
        {
            IWebElement element = driver.FindElement(By.Id("city"));
            element.SendKeys(cityname);
            Thread.Sleep(2000);
        }

        [Given(@"no campo Occupation seleciono a opcao '(.*)'")]
        public void GivenNoCampoOccupationSelecionoAOpcaoEmployee(string occupation)
        {
            new SelectElement(driver.FindElement(By.Id("occupation"))).SelectByText(occupation);
            Thread.Sleep(2000);
        }
        [Given(@"seleciono '([^']*)' no campo Hobbies")]
        public void GivenSelecionoNoCampoHobbies(string hobbies)
        {
            IWebElement element = driver.FindElement(By.XPath("//label[@class='ideal-radiocheck-label'][contains(.,'" + hobbies + "')]"));
            element.Click();
            Thread.Sleep(2000);
            addScreenShot(driver, "Cenario 02 complete");
        }


        [When(@"clico em Next")]
        public void WhenClicoEmNext()
        {
            IWebElement element = driver.FindElement(By.Id("nextenterproductdata"));
            element.Click();
            Thread.Sleep(2000);
        }

        [Then(@"sou redirecionado para a aba Enter Product Data e finalizo o drive")]
        public void ThenSouRedirecionadoParaAAbaEnterProductDataEFinalizoODrive()
        {
            Assert.Equal("Enter Product Data", driver.Title);
            driver.Quit();
        }



    }
}
