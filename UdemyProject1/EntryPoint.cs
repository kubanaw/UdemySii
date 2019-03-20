using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {

        string url = "http://testing.todvachev.com/selectors/class-name/";
        string css = "#post-107 > div > p.testClasss";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        IWebElement element;

        try
        {

            element = driver.FindElement(By.CssSelector(css));        

            if (element.Displayed)
            {
                GreenMessage("Good!");
            }
        }
        catch(NoSuchElementException)
        {
            RedMessage("Not Good!"); 
        }

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
