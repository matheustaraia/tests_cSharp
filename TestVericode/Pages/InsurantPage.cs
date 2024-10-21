using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestVericode.Pages
{


    public class InsurantPage
    {
        private IWebDriver driver;
        private WebDriverWait _wait;

        public InsurantPage(IWebDriver driver)
        {
            this.driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));            
        }

        // Page Elements
        private IWebElement FirstNameField => driver.FindElement(By.Id("firstname"));
        private IWebElement LastNameField => driver.FindElement(By.Id("lastname"));
        private IWebElement DateOfBirthField => driver.FindElement(By.Id("birthdate"));
        private IWebElement GenderMaleRadioButton => driver.FindElement(By.XPath("//label[@class='ideal-radiocheck-label'][contains(.,'Male')]"));
        private IWebElement CountryDropdown => driver.FindElement(By.Id("country"));
        private IWebElement ZipCodeField => driver.FindElement(By.Id("zipcode"));
        private IWebElement CityField => driver.FindElement(By.Id("city"));
        private IWebElement OccupationDropdown => driver.FindElement(By.Id("occupation"));
        private IWebElement CliffDivingCheckbox => driver.FindElement(By.XPath("//label[@class='ideal-radiocheck-label'][contains(.,'Cliff Diving')]"));
        private IWebElement NextButton => driver.FindElement(By.Id("nextenterproductdata"));

        // Page Methods
        public void EnterFirstName(string firstName)
        {
            FirstNameField.SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            LastNameField.SendKeys(lastName);
        }

        public void EnterDateOfBirth(string dateOfBirth)
        {
            DateOfBirthField.SendKeys(dateOfBirth);
        }

        public void SelectGenderMale()
        {
            
            GenderMaleRadioButton.Click();

        }

        public void SelectCountry(string country)
        {
            var selectCountry = new SelectElement(CountryDropdown);
            selectCountry.SelectByText(country);
        }

        public void EnterZipCode(string zipCode)
        {
            ZipCodeField.SendKeys(zipCode);
        }

        public void EnterCity(string city)
        {
            CityField.SendKeys(city);
        }

        public void SelectOccupation(string occupation)
        {
            var selectOccupation = new SelectElement(OccupationDropdown);
            selectOccupation.SelectByText(occupation);
        }

        public void SelectHobbyCliffDiving()
        {
            if (!CliffDivingCheckbox.Selected)
            {
                CliffDivingCheckbox.Click();
            }
        }

        public void ClickNext()
        {
            NextButton.Click();
        }
    }

}
