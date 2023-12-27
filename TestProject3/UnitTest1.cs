using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace TestProject3
{

    public class Create1Test
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void create1()
        {
            driver.Navigate().GoToUrl("https://guest:welcome2qauto@qauto2.forstudy.space/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 714);
            driver.FindElement(By.CssSelector(".hero-descriptor_btn")).Click();
            driver.FindElement(By.Id("signupName")).Click();
            driver.FindElement(By.Id("signupName")).SendKeys("qwert");
            driver.FindElement(By.Id("signupLastName")).SendKeys("test");
            driver.FindElement(By.Id("signupEmail")).Click();
            driver.FindElement(By.Id("signupEmail")).SendKeys("qwertyty@mail.com");
            driver.FindElement(By.Id("signupPassword")).Click();
            driver.FindElement(By.Id("signupPassword")).SendKeys("Qwerty-11!");
            driver.FindElement(By.Id("signupRepeatPassword")).Click();
            driver.FindElement(By.Id("signupRepeatPassword")).SendKeys("Qwerty-11!");
            driver.FindElement(By.CssSelector(".btn-primary:nth-child(1)")).Click();
        }
    }

    public class LoginTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void login()
        {
            driver.Navigate().GoToUrl("https://guest:welcome2qauto@qauto2.forstudy.space/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 714);
            driver.FindElement(By.CssSelector(".btn-outline-white")).Click();
            driver.FindElement(By.Id("signinEmail")).Click();
            driver.FindElement(By.Id("signinEmail")).SendKeys("qwertyty@mail.com");
            driver.FindElement(By.Id("signinPassword")).Click();
            driver.FindElement(By.Id("signinPassword")).SendKeys("Qwerty-11!");
            driver.FindElement(By.CssSelector(".btn-primary:nth-child(2)")).Click();
            {
                WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(2));
                wait.Until(driver => driver.FindElements(By.XPath("//a[@class=\"btn btn-link text-danger btn-sidebar sidebar_btn\"]")).Count > 0);
            }
            var elements = driver.FindElements(By.XPath("//a[@class=\"btn btn-link text-danger btn-sidebar sidebar_btn\"]"));
            Assert.True(elements.Count > 0);
        }

    }

    public class AddcarTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void addcar()
        {
            driver.Navigate().GoToUrl("https://guest:welcome2qauto@qauto2.forstudy.space/panel/garage");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 714);
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            {
                var dropdown = driver.FindElement(By.Id("addCarBrand"));
                dropdown.FindElement(By.XPath("//option[. = 'BMW']")).Click();
            }
            {
                var dropdown = driver.FindElement(By.Id("addCarBrand"));
                dropdown.FindElement(By.XPath("//option[. = 'Ford']")).Click();
            }
            {
                var dropdown = driver.FindElement(By.Id("addCarBrand"));
                dropdown.FindElement(By.XPath("//option[. = 'Porsche']")).Click();
            }
            {
                var dropdown = driver.FindElement(By.Id("addCarBrand"));
                dropdown.FindElement(By.XPath("//option[. = 'Fiat']")).Click();
            }
            {
                var dropdown = driver.FindElement(By.Id("addCarModel"));
                dropdown.FindElement(By.XPath("//option[. = 'Ducato']")).Click();
            }
            {
                var dropdown = driver.FindElement(By.Id("addCarModel"));
                dropdown.FindElement(By.XPath("//option[. = 'Panda']")).Click();
            }
            {
                var dropdown = driver.FindElement(By.Id("addCarModel"));
                dropdown.FindElement(By.XPath("//option[. = 'Punto']")).Click();
            }
            {
                var dropdown = driver.FindElement(By.Id("addCarModel"));
                dropdown.FindElement(By.XPath("//option[. = 'Scudo']")).Click();
            }
            driver.FindElement(By.Id("addCarMileage")).SendKeys("1");
            driver.FindElement(By.Id("addCarMileage")).SendKeys(Keys.Up);
            driver.FindElement(By.Id("addCarMileage")).SendKeys("2");
            driver.FindElement(By.Id("addCarMileage")).SendKeys(Keys.Up);
            driver.FindElement(By.Id("addCarMileage")).SendKeys("3");
            driver.FindElement(By.Id("addCarMileage")).SendKeys(Keys.Up);
            driver.FindElement(By.Id("addCarMileage")).SendKeys("4");
            driver.FindElement(By.Id("addCarMileage")).SendKeys("1");
            driver.FindElement(By.Id("addCarMileage")).SendKeys(Keys.Up);
            driver.FindElement(By.Id("addCarMileage")).SendKeys("2");
            driver.FindElement(By.Id("addCarMileage")).SendKeys(Keys.Up);
            driver.FindElement(By.Id("addCarMileage")).SendKeys("3");
            driver.FindElement(By.Id("addCarMileage")).SendKeys(Keys.Up);
            driver.FindElement(By.Id("addCarMileage")).SendKeys("4");
            driver.FindElement(By.Id("addCarMileage")).SendKeys(Keys.Up);
            driver.FindElement(By.Id("addCarMileage")).SendKeys("5");
            driver.FindElement(By.Id("addCarMileage")).SendKeys(Keys.Tab);
            driver.FindElement(By.CssSelector(".modal-footer > .btn-primary")).Click();
        }
    }

    public class ExpenseTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void expense()
        {
            driver.Navigate().GoToUrl("https://guest:welcome2qauto@qauto2.forstudy.space/panel/garage");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 714);
            driver.FindElement(By.CssSelector(".car_add-expense")).Click();
            driver.FindElement(By.CssSelector(".modal-body")).Click();
            driver.FindElement(By.Id("addExpenseMileage")).SendKeys("13");
            driver.FindElement(By.Id("addExpenseLiters")).Click();
            driver.FindElement(By.Id("addExpenseLiters")).SendKeys("10");
            driver.FindElement(By.Id("addExpenseTotalCost")).Click();
            driver.FindElement(By.Id("addExpenseTotalCost")).SendKeys("10");
            driver.FindElement(By.CssSelector(".modal-footer")).Click();
            driver.FindElement(By.CssSelector(".modal-footer > .btn-primary")).Click();
        }
    }

    public class DeleteTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void delete()
        {
            driver.Navigate().GoToUrl("https://guest:welcome2qauto@qauto2.forstudy.space/panel/garage");
            driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
            driver.FindElement(By.LinkText("Settings")).Click();
            driver.FindElement(By.CssSelector(".btn-danger-bg")).Click();
            driver.FindElement(By.CssSelector(".btn-danger")).Click();
        }
    }
}