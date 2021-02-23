using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCSharpNetCore
{
    public class Tests: DriverHelper
    {   
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This is a Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            //Driver.Navigate().GoToUrl("https://executeautomation.com");
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Driver.Manage().Window.Maximize();
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            //Console.WriteLine("This is Test1");
            Assert.Pass();
        }
    } 
}
