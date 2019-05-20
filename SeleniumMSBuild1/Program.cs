using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumMSBuild1
{
    class Program
    {
        static void Main(string[] args)
        {
      
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            string title=driver.Title;
            Console.WriteLine("Title is: "+title);
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys("Bhavna Corp");
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys(Keys.Enter);
            driver.Quit();
        }
    }
}
