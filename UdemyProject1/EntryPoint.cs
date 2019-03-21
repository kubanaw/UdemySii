﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;

    static void Main()
    {

        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";

        driver.Navigate().GoToUrl(url);

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(1)"));
        
        checkBox.Click();

        Thread.Sleep(3000);

        driver.Quit();

    }
}
