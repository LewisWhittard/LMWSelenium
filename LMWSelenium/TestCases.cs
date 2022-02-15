using NUnit.Framework;
using LMWSelenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using LMWSelenium.PageModels.PageModels;
using LMWSelenium.PageModels.StandardPage;
using System.Collections.Generic;

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

		#region Chrome

		[Test]
		public void HomePageNavBarSearchButtonTestChrome()
		{
			Driver = new ChromeDriver();

			StandardPageModel PageModel = new StandardPageModel();

			PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

			HomePage Home = new HomePage(Driver);

			Home.TestSearchNavBarButton(Driver);

			SearchPage Search = new SearchPage(Driver);

			Search.CheckSearchButtonPost();

			Driver.Close();

		}

		[Test]
		public void HomePageNavBarHomeButtonTestChrome()
		{
			Driver = new ChromeDriver();

			StandardPageModel PageModel = new StandardPageModel();

			PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

			HomePage Home = new HomePage(Driver);

			Home.TestSearchNavBarButton(Driver);

			Driver.Close();

		}

		[Test]
		public void HomePageOverlayProgrammingButtonChrome()
		{
			
			Driver = new ChromeDriver();

			StandardPageModel PageModel = new StandardPageModel();

			PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

			HomePage Home = new HomePage(Driver);
			Home.TestProgrammingButton(Driver);

			SearchPage Search = new SearchPage(Driver);
			Search.CheckProgrammingButtonPost();

			Driver.Close();


		}

		[Test]
		public void HomePageOverlayTestButtonChrome()
		{

			Driver = new ChromeDriver();

			StandardPageModel PageModel = new StandardPageModel();

			PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

			HomePage Home = new HomePage(Driver);
			Home.TestTestButton(Driver);

			SearchPage Search = new SearchPage(Driver);
			Search.CheckTestingButtonPost();

			Driver.Close();
		}

		[Test]
		public void HomePageOverlayGamesButtonChrome()
		{

			Driver = new ChromeDriver();

			StandardPageModel PageModel = new StandardPageModel();

			PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

			HomePage Home = new HomePage(Driver);
			Home.TestGamesButton(Driver);

			SearchPage Search = new SearchPage(Driver);
			Search.CheckGamesButtonPost();

			Driver.Close();
		}

		[Test]
		public void HomePageOverlayTwoDAssetsButtonChrome()
		{

			Driver = new ChromeDriver();

			StandardPageModel PageModel = new StandardPageModel();

			PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

			HomePage Home = new HomePage(Driver);
			Home.TestTwoDAssetsButton(Driver);

			SearchPage Search = new SearchPage(Driver);
			Search.CheckTwoDButtonPost();

			Driver.Close();
		}

		[Test]
		public void HomePageOverlayThreeDAssetsButtonChrome()
		{

			Driver = new ChromeDriver();

			StandardPageModel PageModel = new StandardPageModel();

			PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

			HomePage Home = new HomePage(Driver);
			Home.TestThreeDAssetsButton(Driver);

			SearchPage Search = new SearchPage(Driver);
			Search.CheckThreeDButtonPost();

			Driver.Close();
		}

		[Test]
		public void HomePageOverlayBlogButtonChrome()
		{

			Driver = new ChromeDriver();

			StandardPageModel PageModel = new StandardPageModel();

			PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

			HomePage Home = new HomePage(Driver);
			Home.TestBlogButton(Driver);

			SearchPage Search = new SearchPage(Driver);
			Search.BlogButtonPost();

			Driver.Close();
		}


		#endregion

	}
}