using NUnit.Framework;
using LMWSelenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using LMWSelenium.PageModels.PageModels;

namespace LMWSelenium
{
	public class SmokeTests
	{
		IWebDriver Driver;

		[Test]
		public void SmokeTestChrome()
		{
			Driver = new ChromeDriver();

			SmokeTestLogic(Driver);

		}

		[Test]
		public void SmokeTestEdge()
		{
			Driver = new EdgeDriver();

			SmokeTestLogic(Driver);

		}

		[Test]
		public void SmokeTestFirefox()
		{
			Driver = new FirefoxDriver();

			SmokeTestLogic(Driver);

		}

		[Test]
		public void SmokeTestSafari()
		{
			Driver = new SafariDriver();

			SmokeTestLogic(Driver);

		}

		public void SmokeTestLogic(IWebDriver driver)
		{
			Driver.Navigate().GoToUrl("https://www.lewiswhittard.co.uk");
			Assert.AreEqual(Driver.Title, "Home Page - Lewis Whittard Software Development");

			Driver.Navigate().GoToUrl("https://www.lewiswhittard.co.uk/search");
			Assert.AreEqual(Driver.Title, "Index - Lewis Whittard Software Development");

			Driver.Navigate().GoToUrl("https://www.lewiswhittard.co.uk/Search/Modified");
			Assert.AreEqual(Driver.Title, "Index - Lewis Whittard Software Development");

			Driver.Navigate().GoToUrl("https://www.lewiswhittard.co.uk/PortfolioPiece?Id=0");
			Assert.AreEqual(Driver.Title, "Index - Lewis Whittard Software Development");
		}

	}

	public class HomePageTests
	{
		IWebDriver Driver;

		[Test]
		public void HomePageProgrammingButtonTest()
		{
			Driver = new ChromeDriver();

			HomePage Page = new HomePage();

		}

		
	}
}