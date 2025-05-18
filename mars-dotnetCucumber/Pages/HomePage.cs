using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace mars_dotnetCucumber.Pages
{
    public class HomePage
    {
        // verify user is login successfully
        public void userIsInHomePage(IWebDriver driver)
        {

            IWebElement MarsLogo = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/a"));
            if (MarsLogo.Text == "Mars Logo")
            {
                Console.WriteLine("User Login Successfully! Test is Passed");
            }
            else
            {
                Console.WriteLine("User didn't Login! Test Failed");
            }

        }
    }
}
