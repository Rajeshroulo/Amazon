using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
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

        [FindsBy(How = How.XPath, Using = "//a[@id='hlb-ptc-btn-native']")]
        public IWebElement proceed;

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[2]/div/div[1]/form[1]/div/div[1]/div[2]/span/a")]
        public IWebElement address;

        public void EnterAddress()
        {
            proceed.Click();
            Thread.Sleep(9000);
            address.Click();
            Thread.Sleep(7000);
        }        
    }
}
