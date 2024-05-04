using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace oopConcepts
{
    public class baseClass
    {
        //chrome driver initialized
        public static ChromeDriver chromeDriver;
        public string url = "https://www.saucedemo.com/";

        public void ChromeDriverInitialized()
        {
            chromeDriver = new ChromeDriver();

        }


        //open vroweser and open URL

        public void OpenBrowerserAndUrl()
        {
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl(url);

        }

        //close and dispose
        public void DisposeDriver(){
            
            chromeDriver.Close();
        }

    }
}
