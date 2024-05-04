using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using oopConcepts.Login_Page;

namespace oopConcepts
{
    public class SauceDemoTestClass
    {
        loginPageClass loginPageClass = new loginPageClass();
        [Test, Order(1)]

        public void sauceDemoTest()
        {
            loginPageClass.ChromeDriverInitialized();
            loginPageClass.OpenBrowerserAndUrl();

            loginPageClass.ValidLogin();
            loginPageClass.ValidateSuccesfullLogin();



            //loginPageClass.DisposeDriver();

        }

        [Test, Order(2)]


        public void CheckOutDemo()
        {
            //loginPageClass.ChromeDriverInitialized();
            //loginPageClass.OpenBrowerserAndUrl();

            loginPageClass.ValidCheckout();

            loginPageClass.CheckoutPage();


            //loginPageClass.ValidLogin();
            //loginPageClass.ValidateSuccesfullLogin();



            //loginPageClass.DisposeDriver();

        }


    }
}
