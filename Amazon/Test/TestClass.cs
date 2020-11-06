using Amazon.Base;
using Amazon.Data;
using Amazon.Pages;
using NUnit.Framework;

namespace Amazon.Test
{
    public class TestClass : BaseClass
    {
        UserData data = new UserData();

       [Test,Order(1)]  
       public void AccountLogin()
       {
            var login = new LoginPage(driver);
            login.AmazonLogin(data.email,data.password);
            Assert.AreEqual("Mobiles", login.MobilePhones());
       } 

       [Test,Order(2)]
       public void MobileSearch()
       {
            var search = new HomePage(driver);
            search.SearchMobile();       
       }

       [Test, Order(3)]
       public void DeliveryAddress()
       {
            var address = new AddressPage(driver);
            address.EnterAddress();
       }

       [Test, Order(4)]
       public void AmazonLogout()
       {
            var logout = new Logout(driver);
            logout.AccountLogout();
       } 

    } 
}
