﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {

        string url = "http://testing.todorvachev.com/selectors/id/";
        string ID = "testImage";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.Id(ID));

        if (element.Displayed)
        {
            GreenMessage("Good");
        }
        else
        {
            RedMessage("Not Good");
        }

        Thread.Sleep(3000);
        driver.Quit();
   
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
