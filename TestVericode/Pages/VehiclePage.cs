using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras;

namespace TestVericode.Pages
{

    public class VehiclePage
    {
        private IWebDriver driver;
        private WebDriverWait _wait;

        public VehiclePage(IWebDriver driver)
        {
            this.driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
        }
        //Elementos da página
        private IWebElement AutomobileOption => driver.FindElement(By.Id("nav_automobile"));
        private IWebElement MakeDropdown => driver.FindElement(By.Id("make"));
        private IWebElement EnginePerformanceField => driver.FindElement(By.Id("engineperformance"));
        private IWebElement DateOfManufactureField => driver.FindElement(By.Id("dateofmanufacture"));
        private IWebElement NumberOfSeatsDropdown => driver.FindElement(By.Id("numberofseats"));
        private IWebElement FuelTypeDropdown => driver.FindElement(By.Id("fuel"));
        private IWebElement ListPriceField => driver.FindElement(By.Id("listprice"));
        private IWebElement AnnualMileageField => driver.FindElement(By.Id("annualmileage"));
        private IWebElement NextButton => driver.FindElement(By.Id("nextenterinsurantdata"));

        //Methods
        public void SelectAutomobileOption()
        {
            AutomobileOption.Click();
        }

        public void SelectMake(string make)
        {
            var selectElement = new SelectElement(MakeDropdown);
            selectElement.SelectByText(make);
        }

        public void EnterEnginePerformance(string performance)
        {
            EnginePerformanceField.Clear();
            EnginePerformanceField.SendKeys(performance);
        }

        public void EnterDateOfManufacture(string date)
        {
            DateOfManufactureField.SendKeys(date);
        }

        public void SelectNumberOfSeats(string seats)
        {
            var selectElement = new SelectElement(NumberOfSeatsDropdown);
            selectElement.SelectByText(seats);
        }

        public void SelectFuelType(string fuelType)
        {
            var selectElement = new SelectElement(FuelTypeDropdown);
            selectElement.SelectByText(fuelType);
        }

        public void EnterListPrice(string price)
        {
            ListPriceField.Clear();
            ListPriceField.SendKeys(price);
        }

        public void EnterAnnualMileage(string mileage)
        {
            AnnualMileageField.Clear();
            AnnualMileageField.SendKeys(mileage);
        }

        public void ClickNext()
        {
            NextButton.Click();
        }

        public void VerifyEnterInsurantDataPage()
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("enterinsurantdata"));
            if (!driver.Url.Contains("enterinsurantdata"))
            {
                throw new Exception("Not redirected to the Insurant Data page");
            }
        }
    }
}
