using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;
using System.Threading;

namespace Amazon.Pages
{
    public class AddressPage
    {
        public IWebDriver driver;
        public AddressPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body/div/div/div/form/div/div/div/div/div/div/div/span/span/span/span[1]")]
        public IWebElement dropDown;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Ship to a new address')]")]
        public IWebElement newAddress;

        [FindsBy(How = How.XPath, Using = "//iframe[@class='a-popover-iframe']")]
        public IWebElement frame;

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div[1]//form[1]//div[4]//input[1]")]
        public IWebElement name;

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div[1]//form[1]//div[6]//input[1]")]
        public IWebElement phone;

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div[1]//form[1]//div[8]//input[1]")]
        public IWebElement pin;

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div[1]//form[1]//div[10]//input[1]")]
        public IWebElement home;

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div[1]//form[1]//div[12]//input[1]")]
        public IWebElement area;

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div[1]//form[1]//div[14]//input[1]")]
        public IWebElement landMark;

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div[1]//form[1]//div[16]//input[1]")]
        public IWebElement city;

        [FindsBy(How = How.XPath, Using = "//body/div/div/div/div/div[1]/form[1]/div[1]/div[1]/div[1]/div[18]/span[1]/span[1]/span[1]/span[1]")]
        public IWebElement state;

        [FindsBy(How = How.ClassName, Using = "a-active")]
        public IWebElement andhraPradesh;

        [FindsBy(How = How.XPath, Using = "//body/div/div/div/div/div[1]/form[1]/div[1]/div[2]/div[4]/span[1]/span[1]/span[1]/span[1]")]
        public IWebElement addressType;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Office')]")]
        public IWebElement office;

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div[1]//form[1]//span[1]//input[1]")]
        public IWebElement addAddress;

        [FindsBy(How = How.Name, Using = "continue-bottom")]
        public IWebElement continueButton;

        public void EnterAddress()
        {
            Thread.Sleep(5000);
            dropDown.Click();
            newAddress.Click();
            driver.SwitchTo().Frame(frame);
            Thread.Sleep(8000);
            name.SendKeys(ConfigurationManager.AppSettings["Name"]);
            phone.SendKeys(ConfigurationManager.AppSettings["Mobile"]);
            pin.SendKeys(ConfigurationManager.AppSettings["Pin"]);
            home.SendKeys(ConfigurationManager.AppSettings["Home"]);
            area.SendKeys(ConfigurationManager.AppSettings["Address"]);
            landMark.SendKeys(ConfigurationManager.AppSettings["Mark"]);
            city.SendKeys(ConfigurationManager.AppSettings["City"]);           
        }

        public void AddAddress()
        {
            state.Click();
            andhraPradesh.Click();
            addressType.Click();
            office.Click();
            addAddress.Click();
            Thread.Sleep(8000);
            continueButton.Click();
            Thread.Sleep(5000);
        }
    }
}
