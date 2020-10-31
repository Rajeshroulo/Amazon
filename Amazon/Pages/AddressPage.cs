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

        [FindsBy(How = How.XPath, Using = "//body/div[@id='a-page']/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[5]/div[1]/form[1]/span[1]/span[1]/span[1]/input[1]")]
        public IWebElement cart;

        [FindsBy(How = How.XPath, Using = "//a[@id='hlb-ptc-btn-native']")]
        public IWebElement proceed;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[5]/div[2]/div[1]/form[1]/div[1]/div[1]/div[2]/span[1]/a[1]")]
        public IWebElement address;

        public void EnterAddress()
        {
            cart.Click();
            Thread.Sleep(5000);
            proceed.Click();
            Thread.Sleep(9000);
            address.Click();
            Thread.Sleep(7000);
        }        
    }
}
