using Amazon.Base;
using Amazon.Data;
using Amazon.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Test
{
   public class TestClass : BaseClass
   {
        UserData data = new UserData();
       [Test]  
       public void AccountLogin()
       {
            var login = new LoginPage(driver);
            login.AmazonLogin(data.email,data.password);
            Assert.AreEqual("Mobiles", login.MobilePhones());
       }
   }
}
