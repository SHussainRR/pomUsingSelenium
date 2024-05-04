using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using static System.Net.Mime.MediaTypeNames;

namespace oopConcepts.Login_Page
{
    public class loginPageClass : baseClass
    {
        public void ValidLogin()
        {
            chromeDriver.FindElement(By.Id(LocatorClass.UserName)).SendKeys("standard_user");
            chromeDriver.FindElement(By.Id(LocatorClass.Password)).SendKeys("secret_sauce");
            chromeDriver.FindElement(By.Id(LocatorClass.loginBtn)).Click();  
            //chromeDriver.FindElement(By.Id(LocatorClass.loginBtn)).Click();




        }

        public void ValidCheckout() {

            chromeDriver.FindElement(By.XPath(LocatorClass.ClickOnCart)).Click();

            chromeDriver.FindElement(By.XPath(LocatorClass.Const)).Click();

            chromeDriver.FindElement(By.Id("first-name")).SendKeys("hussain");
            chromeDriver.FindElement(By.Id("last-name")).SendKeys("Raza");
            chromeDriver.FindElement(By.Id("postal-code")).SendKeys("7500");

            chromeDriver.FindElement(By.XPath("//input[@id='continue']")).Click();
            chromeDriver.FindElement(By.XPath("//button[@id='finish']")).Click();

        }


        public void ValidateSuccesfullLogin()
        {
            string text = chromeDriver.FindElement(By.XPath(LocatorClass.LoggedInValidationTest)).Text;
            Assert.AreEqual(text, "Products");

        }


        public void CheckoutPage() {

            string text = chromeDriver.FindElement(By.XPath("//h2[contains(text(),'Thank you for your order!')]")).Text;
            Assert.AreEqual(text, "Thank you for your order!");

        }
     
    }
}