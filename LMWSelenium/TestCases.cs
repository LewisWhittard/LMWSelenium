using NUnit.Framework;
using LMWSelenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using LMWSelenium.PageModels.PageModels;
using LMWSelenium.PageModels.StandardPage;

namespace LMWSelenium
{
	public class SmokeTests
	{
		IWebDriver Driver;

		[Test]
		public void SmokeTestChrome()
		{
			StandardPageModel Model = new StandardPageModel();
			
			Driver = new ChromeDriver();

			Model.SmokeTestLogic(Driver);

		}

		[Test]
		public void SmokeTestEdge()
		{
			StandardPageModel Model = new StandardPageModel();


			Driver = new EdgeDriver();

			Model.SmokeTestLogic(Driver);

		}

		[Test]
		public void SmokeTestFirefox()
		{
			StandardPageModel Model = new StandardPageModel();

			Driver = new FirefoxDriver();

			Model.SmokeTestLogic(Driver);

		}

		[Test]
		public void SmokeTestSafari()
		{StandardPageModel Model = new StandardPageModel();
			Driver = new SafariDriver();
			
			Model.SmokeTestLogic(Driver);
		}

	}

	public class HomePageTests
	{
		IWebDriver Driver;

		[Test]
		public void HomePageNavBarSearchButtonTest()
		{
			Driver = new ChromeDriver();

			HomePage Home = new HomePage(Driver);

			Home.TestSearchNavBarButton(Driver);

			SearchPage Search = new SearchPage();
			


		}

		
	}
}