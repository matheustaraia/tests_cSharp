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
using TestVericode.Pages;

namespace TestVericode.StepDefinitions
{
    [Binding]
    public sealed class FormSteps : Reports
    {

        private IWebDriver driver;
        private VehiclePage vehiclePage;
        private InsurantPage insurantPage;

        public FormSteps(IWebDriver driver)
        {
            this.driver = driver;
            vehiclePage = new VehiclePage(driver);
            insurantPage = new InsurantPage(driver);
        }


        //TODO - adicionar o openbrowser no utility
        [Given(@"que eu acesso o site '(.*)'")]
        public void GivenQueEuAcessoOSite(string site)
        {
            driver.Url = site;
            //Validação do título da página
            Assert.Equal("Enter Vehicle Data", driver.Title);
            addScreenShot(driver, "Cenario 01");

        }

        //início dos metodos utilizados no BDD(SPECFLOW)
        [Given(@"clico na opcao Automobile")]
        public void GivenEuValidoQueEstouNaPaginaEnterVehicleData()
        {
            vehiclePage.SelectAutomobileOption();
        }


        [Given(@"seleciono a opcao '(.*)'")]
        public void GivenSelecionoAOpcaoHonda(string marca)
        {

            vehiclePage.SelectMake(marca);
            
        }


        [Given(@"digito no campo Engine Performance o valor '(.*)'")]
        public void GivenDigitoNoCampoEnginePerformanceOValor(string kw)
        {
            vehiclePage.EnterEnginePerformance(kw);            
        }

        [Given(@"digito no campo Date of Manufacture '(.*)'")]
        public void GivenDigitoNoCampoDateOfManufacture(string data)
        {

            vehiclePage.EnterDateOfManufacture(data);
            
        }

        [Given(@"seleciono a opcao '(.*)' no campo Number of Seat")]
        public void GivenSelecionoAOpcaoNoCampoNumberOfSeat(string seats)
        {

            vehiclePage.SelectNumberOfSeats(seats);            
            
        }

        [Given(@"seleciono a opcao '(.*)' no campo Fuel Type")]
        public void GivenSelecionoAOpcaoPetrolNoCampoFuelType(string fuel)
        {
            
            vehiclePage.SelectFuelType(fuel);
            
        }

        [Given(@"digito no campo List Price o valor '(.*)'")]
        public void GivenDigitoNoCampoListPriceOValor(string listPrice)
        {

            vehiclePage.EnterListPrice(listPrice);                        
            
        }

        [Given(@"digito no campo Annual Mileage o valor '(.*)'")]
        public void GivenDigitoNoCampoAnnualMileageOValor(string annualmileage)
        {
            vehiclePage.EnterAnnualMileage(annualmileage);
            Thread.Sleep(2000);
            addScreenShot(driver, "Cenario 01 complete");
        }

        [When(@"clico no botao Next")]
        public void WhenClicoNoBotaoNext()
        {
            vehiclePage.ClickNext();
        }

        [Then(@"sou redirecionado pra aba Enter Insurant Data")]
        public void ThenSouRedirecionadoPraAbaEnterInsurantData()
        {
            Assert.Equal("Enter Insurant Data", driver.Title);
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

            insurantPage.EnterFirstName(firstname);

        }

        [Given(@"digito no campo Last Name o sobrenome '(.*)'")]
        public void GivenDigitoNoCampoLastNameOSobrenome(string lastname)
        {

            insurantPage.EnterLastName(lastname);

        }

        [Given(@"digito no campo Date of Birth a data '(.*)'")]
        public void GivenDigitoNoCampoDateOfBirthAData(string birthdata)
        {

            insurantPage.EnterDateOfBirth(birthdata);

        }

        [Given(@"clico na opcao Male no campo Gender")]
        public void GivenClicoNaOpcaoMaleNoCampoGender()
        {

            insurantPage.SelectGenderMale();

        }

        [Given(@"seleciono a opcao '(.*)' no campo Country")]
        public void GivenSelecionoAOpcaoBrazilNoCampoCountry(string country)
        {

            insurantPage.SelectCountry(country);

        }

        [Given(@"digito no campo Zip Code o cep '(.*)'")]
        public void GivenDigitoNoCampoZipCodeOCep(string zipcode)
        {

            insurantPage.EnterZipCode(zipcode);

        }

        [Given(@"no campo City digito '(.*)'")]
        public void GivenNoCampoCityDigito(string cityname)
        {

            insurantPage.EnterCity(cityname);

        }

        [Given(@"no campo Occupation seleciono a opcao '(.*)'")]
        public void GivenNoCampoOccupationSelecionoAOpcaoEmployee(string occupation)
        {

            insurantPage.SelectOccupation(occupation);

        }
        [Given(@"seleciono Cliff Diving no campo Hobbies")]
        public void GivenSelecionoNoCampoHobbies()
        {
            insurantPage.SelectHobbyCliffDiving();
            Thread.Sleep(2000);
            addScreenShot(driver, "Cenario 02 complete" + DateTime.Now.ToString("yyyyddMM_HHmmss"));
        }


        [When(@"clico em Next")]
        public void WhenClicoEmNext()
        {
            insurantPage.ClickNext();
            Thread.Sleep(2000);
        }

        [Then(@"sou redirecionado para a aba Enter Product Data e finalizo o drive")]
        public void ThenSouRedirecionadoParaAAbaEnterProductDataEFinalizoODrive()
        {
            Assert.Equal("Enter Product Data", driver.Title);
        }

    }
}
