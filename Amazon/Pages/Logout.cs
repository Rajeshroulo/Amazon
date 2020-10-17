using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Amazon.Pages
{
    public class Logout
    {
        public IWebDriver driver;
        public Logout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Hello, Rajesh')]")]
        public IWebElement account;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Sign Out')]")]
        public IWebElement signOut;

      public void AccountLogout()
      {
            account.Click();
            signOut.Click();
      }

    }
}
