using FaceBook_Automation_Demo.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBook_Automation_Demo.DoActions
{
    public class DoActions
    {
        public static void AssertAfterLaunching(IWebDriver driver)
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void LoginToFacebook(IWebDriver driver)
        {
            LoginPage login = new LoginPage(driver);
            login.email.SendKeys("9786124316");
            System.Threading.Thread.Sleep(1000);
            login.password.SendKeys("Login@123");
            System.Threading.Thread.Sleep(1000);
            login.loginBt.Click();
            System.Threading.Thread.Sleep(9000);

        }
    }
}
