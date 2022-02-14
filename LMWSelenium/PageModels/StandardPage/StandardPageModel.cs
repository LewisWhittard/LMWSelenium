using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace LMWSelenium.PageModels.StandardPage
{
	class StandardPageModel
	{
		public void NavigateToPage(IWebDriver driver, String url)
		{
			driver.Navigate().GoToUrl(url);
		}

		public IWebElement FindElementById(IWebDriver driver, string id)
		{
			IWebElement ReturnElement;


			try
			{
				ReturnElement = driver.FindElement(By.Id(id));
			}
			catch (Exception)
			{

				throw;
			}
			

			return ReturnElement;
		}

		public void SmokeTestLogic(IWebDriver driver)
		{
			NavigateToPage(driver, "https://www.lewiswhittard.co.uk");
			AssertAreEqual(driver.Title, "Home Page - Lewis Whittard Software Development");
			NavigateToPage(driver, "https://www.lewiswhittard.co.uk/search");
			AssertAreEqual(driver.Title, "Search - Lewis Whittard Software Development");
			NavigateToPage(driver, "https://lewiswhittard.co.uk/Search/Modified");
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");
			NavigateToPage(driver, "https://lewiswhittard.co.uk/PortfolioPiece?Id=0");
			AssertAreEqual(driver.Title, "Portfolio Piece - Lewis Whittard Software Development");
			CloseDriver(driver);
		}

		public void CloseDriver(IWebDriver driver)
		{
			driver.Close();
		}
		
		public void AssertAreEqual(string valueOne, string valueTwo)
		{
			Assert.AreEqual(valueOne, valueTwo);
		}

		public void ClickButton(IWebElement button)
		{
			button.Click();
		}

		public string CheckTickBoxValueIsTrue(IWebElement tickbox)
		{
			string TickboxValue = tickbox.GetAttribute("checked");

			AssertAreEqual(TickboxValue, "true");

			return TickboxValue;
		}

		public string CheckTickBoxValueIsFalse(IWebElement tickbox)
		{
			string TickboxValue = tickbox.GetAttribute("checked");

			AssertAreEqual(TickboxValue, null);

			return TickboxValue;
		}

	}
}
