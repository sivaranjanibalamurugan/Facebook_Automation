using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBook_Automation_Demo.Pages
{
    class RegisterPage
    {
        public static void AssertAfterLaunching(IWebDriver driver)
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void SignUpintofacebook(IWebDriver driver)
        {

            IWebElement button = driver.FindElement(By.XPath("//*[@class='_6ltg'][2]"));
            button.Click();
            System.Threading.Thread.Sleep(4000);

            IWebElement firstname = driver.FindElement(By.Name("firstname"));
            firstname.SendKeys("Siva");
            System.Threading.Thread.Sleep(4000);

            IWebElement lastname = driver.FindElement(By.Name("lastname"));
            firstname.SendKeys("Ranjani");
            System.Threading.Thread.Sleep(4000);

            IWebElement reg_email__ = driver.FindElement(By.Name("reg_email__"));
            reg_email__.SendKeys("sivaranjanib99@gmail.com");
            System.Threading.Thread.Sleep(4000);

            IWebElement reg_passwd__ = driver.FindElement(By.Name("reg_passwd__"));
            reg_passwd__.SendKeys("login@123");
            System.Threading.Thread.Sleep(4000);

            SelectElement element = new SelectElement(driver.FindElement(By.Name("birthday_day")));
            element.SelectByText("10");
            System.Threading.Thread.Sleep(4000);

            SelectElement element1 = new SelectElement(driver.FindElement(By.Id("month")));
            element1.SelectByValue("Sep");
            System.Threading.Thread.Sleep(4000);

            SelectElement element2 = new SelectElement(driver.FindElement(By.Id("year")));
            element2.SelectByValue("1999");
            System.Threading.Thread.Sleep(4000);

            IWebElement Female = driver.FindElement(By.XPath("//input[@type = 'radio' and @value = '2']"));
            Female.Click();
            System.Threading.Thread.Sleep(4000);

            IWebElement submit = driver.FindElement(By.Name("submit"));
            submit.Click();
            System.Threading.Thread.Sleep(4000);

        }
    }
}
