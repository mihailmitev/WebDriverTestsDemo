using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test_Calculator
{
    public class WebDriverCalculator
    {
        private ChromeDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
            driver.Url = "https://number-calculator.nakov.repl.co";
        }
        [OneTimeTearDown]
        public void ShutDown()
        {
            driver.Quit();
        }
        [Test]
        public void Test_Calculator()
        {
            var field1 = driver.FindElement(By.Id("number1"));
            var field2 = driver.FindElement(By.Id("number2"));
            var operation = driver.FindElement(By.Id("operation"));
            var calculate = driver.FindElement(By.Id("calcButton"));
            var resultField = driver.FindElement(By.Id("result"));
            var clearField = driver.FindElement(By.Id("resetButton"));

            field1.SendKeys("5");
            operation.SendKeys("+");
            field2.SendKeys("6");
            calculate.Click();
            string expectedValue = "Result: 11";
            Assert.That(expectedValue, Is.EqualTo(resultField.Text));

        }
    }
}