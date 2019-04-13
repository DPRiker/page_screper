using System;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;

namespace Page_scrapper
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("web page address");
            string link = Console.ReadLine();
            link = "https://rozetka.com.ua";
            if(!string.IsNullOrWhiteSpace(link))
            {               
               // using (WebClient client = new WebClient())
                //{
                  //  string htmlCode = client.DownloadString(link);
                //} 
                IWebDriver driver = new ChromeDriver(@"/Users/dishdishes/Downloads/chromedriver");
                driver.Navigate().GoToUrl(@link);
                string html = driver.PageSource;
            }
            Console.ReadKey();
        }
    }
}
