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

		class Chrome
		{
			IWebDriver Driver;

			[Test]
			public void SmokeTest()
			{
				StandardPageModel Model = new StandardPageModel();

				Driver = new ChromeDriver();

				Model.SmokeTestLogic(Driver);

			}
		}

		class Edge
		{
			IWebDriver Driver;

			[Test]
			public void SmokeTest()
			{
				StandardPageModel Model = new StandardPageModel();


				Driver = new EdgeDriver();

				Model.SmokeTestLogic(Driver);

			}
		}


		class Firefox
		{
			IWebDriver Driver;
			[Test]
			public void SmokeTest()
			{
				StandardPageModel Model = new StandardPageModel();

				Driver = new FirefoxDriver();

				Model.SmokeTestLogic(Driver);

			}
		}


		class Safari
		{
			IWebDriver Driver;
			[Test]
			public void SmokeTest()
			{
				StandardPageModel Model = new StandardPageModel();
				Driver = new SafariDriver();

				Model.SmokeTestLogic(Driver);
			}
		}

	}

	public class HomePageTests
	{
		class Chrome
		{
			IWebDriver Driver;

			[Test]
			public void HomePageNavBarSearchButtonTest()
			{
				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);

				Home.TestSearchNavBarButton(Driver);

				SearchPage Search = new SearchPage(Driver);

				Search.CheckSearchButtonPost();

				Driver.Quit();

			}

			[Test]
			public void HomePageNavBarHomeButtonTest()
			{
				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);

				Home.TestHomeNavBarButton(Driver);

				Driver.Quit();

			}

			[Test]
			public void HomePageOverlayProgrammingButton()
			{

				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestProgrammingButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckProgrammingButtonPost();

				Driver.Quit();


			}

			[Test]
			public void HomePageOverlayTestButton()
			{

				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestTestButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckTestingButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomePageOverlayGamesButton()
			{

				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestGamesButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckGamesButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomePageOverlayTwoDAssetsButton()
			{

				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestTwoDAssetsButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckTwoDButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomePageOverlayThreeDAssetsButton()
			{

				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestThreeDAssetsButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckThreeDButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomePageOverlayBlogButton()
			{

				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestBlogButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.BlogButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomeLogoButton()
			{

				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestLogoButton(Driver);
				Driver.Quit();
			}

			[Test]
			public void HomelinkedinButton()
			{
				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();



				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestLinkedinButton(Driver);

				Driver.Quit();
			}
		}

		class Firefox
		{
			IWebDriver Driver;

			[Test]
			public void HomePageNavBarSearchButtonTest()
			{
				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);

				Home.TestSearchNavBarButton(Driver);

				SearchPage Search = new SearchPage(Driver);

				Search.CheckSearchButtonPost();

				Driver.Quit();

			}

			[Test]
			public void HomePageNavBarHomeButtonTest()
			{
				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);

				Home.TestHomeNavBarButton(Driver);

				Driver.Quit();

			}

			[Test]
			public void HomePageOverlayProgrammingButton()
			{

				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestProgrammingButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckProgrammingButtonPost();

				Driver.Quit();


			}

			[Test]
			public void HomePageOverlayTestButton()
			{

				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestTestButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckTestingButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomePageOverlayGamesButton()
			{

				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestGamesButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckGamesButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomePageOverlayTwoDAssetsButton()
			{

				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestTwoDAssetsButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckTwoDButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomePageOverlayThreeDAssetsButton()
			{

				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestThreeDAssetsButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckThreeDButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomePageOverlayBlogButton()
			{

				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestBlogButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.BlogButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomeLogoButton()
			{

				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestLogoButton(Driver);
				Driver.Quit();
			}

			[Test]
			public void HomelinkedinButton()
			{
				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();



				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestLinkedinButton(Driver);
				Driver.Quit();
			}
		}

		class Edge
		{
			IWebDriver Driver;

			[Test]
			public void HomePageNavBarSearchButtonTest()
			{
				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);

				Home.TestSearchNavBarButton(Driver);

				SearchPage Search = new SearchPage(Driver);

				Search.CheckSearchButtonPost();

				Driver.Close();

			}

			[Test]
			public void HomePageNavBarHomeButtonTest()
			{
				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);

				Home.TestHomeNavBarButton(Driver);

				Driver.Close();

			}

			[Test]
			public void HomePageOverlayProgrammingButton()
			{

				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestProgrammingButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckProgrammingButtonPost();

				Driver.Close();


			}

			[Test]
			public void HomePageOverlayTestButton()
			{

				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestTestButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckTestingButtonPost();

				Driver.Close();
			}

			[Test]
			public void HomePageOverlayGamesButton()
			{

				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestGamesButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckGamesButtonPost();

				Driver.Close();
			}

			[Test]
			public void HomePageOverlayTwoDAssetsButton()
			{

				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestTwoDAssetsButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckTwoDButtonPost();

				Driver.Close();
			}

			[Test]
			public void HomePageOverlayThreeDAssetsButton()
			{

				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestThreeDAssetsButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckThreeDButtonPost();

				Driver.Close();
			}

			[Test]
			public void HomePageOverlayBlogButton()
			{

				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestBlogButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.BlogButtonPost();

				Driver.Close();
			}

			[Test]
			public void HomeLogoButton()
			{

				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestLogoButton(Driver);
				Driver.Close();
			}

			[Test]
			public void HomelinkedinButton()
			{
				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();



				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestLinkedinButton(Driver);

				Driver.Close();
			}
		}

		class Safari
		{
			IWebDriver Driver;

			[Test]
			public void HomePageNavBarSearchButtonTest()
			{
				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);

				Home.TestSearchNavBarButton(Driver);

				SearchPage Search = new SearchPage(Driver);

				Search.CheckSearchButtonPost();

				Driver.Quit();

			}

			[Test]
			public void HomePageNavBarHomeButtonTest()
			{
				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);

				Home.TestHomeNavBarButton(Driver);

				Driver.Quit();

			}

			[Test]
			public void HomePageOverlayProgrammingButton()
			{

				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestProgrammingButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckProgrammingButtonPost();

				Driver.Quit();


			}

			[Test]
			public void HomePageOverlayTestButton()
			{

				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestTestButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckTestingButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomePageOverlayGamesButton()
			{

				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestGamesButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckGamesButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomePageOverlayTwoDAssetsButton()
			{

				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestTwoDAssetsButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckTwoDButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomePageOverlayThreeDAssetsButton()
			{

				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestThreeDAssetsButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.CheckThreeDButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomePageOverlayBlogButton()
			{

				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestBlogButton(Driver);

				SearchPage Search = new SearchPage(Driver);
				Search.BlogButtonPost();

				Driver.Quit();
			}

			[Test]
			public void HomeLogoButton()
			{

				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestLogoButton(Driver);
				Driver.Quit();
			}

			[Test]
			public void HomelinkedinButton()
			{
				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();



				PageModel.NavigateToPage(Driver, "https://www.lewiswhittard.co.uk");

				HomePage Home = new HomePage(Driver);
				Home.TestLinkedinButton(Driver);

				Driver.Quit();
			}
		}
	}

	public class SearchPageTests
	{
		

		class Chrome
		{
			IWebDriver Driver;
			[Test]
			public void TestSearchFunctionAndTickboxAllFalseNoResult()
			{
				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesFalse(Driver);

				SearchPage SearchModified = new SearchPage(Driver);

				SearchModified.SearchTestAllTickBoxesFalsePost(Driver);

				Driver.Quit();

			}

			[Test]
			public void TestSearchFunctionAndTickboxAllTrueNoResult()
			{
				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesTrueNoResult(Driver);

				SearchPage SearchModified = new SearchPage(Driver);

				SearchModified.SearchTestAllTicketBoxesTrueNoResultPost(Driver);

				Driver.Quit();

			}

			[Test]
			public void TestSearchFunctionResult()
			{
				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesTrueResult(Driver);

				SearchPage SearchModified = new SearchPage(Driver);

				SearchModified.SearchTestAllTickBoxesTrueResultPost(Driver);

				Driver.Quit();

			}

			[Test]
			public void TestSearchFunctionModifiedSearchButton()
			{
				Driver = new ChromeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search/modified");

				SearchPage Search = new SearchPage(Driver);
				
				Search.SearchTestAllTickBoxesTrue(Driver);

				SearchPage SearchPost = new SearchPage(Driver);
				
				SearchPost.SearchTestAllTickBoxesTrueResultPost(Driver);



				Driver.Quit();

			}
		}

		class Firefox
		{
			IWebDriver Driver;
			[Test]
			public void TestSearchFunctionAndTickboxAllFalseNoResult()
			{
				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesFalse(Driver);

				SearchPage SearchModified = new SearchPage(Driver);

				SearchModified.SearchTestAllTickBoxesFalsePost(Driver);

				Driver.Quit();

			}

			[Test]
			public void TestSearchFunctionAndTickboxAllTrueNoResult()
			{
				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesTrueNoResult(Driver);

				SearchPage SearchModified = new SearchPage(Driver);

				SearchModified.SearchTestAllTicketBoxesTrueNoResultPost(Driver);

				Driver.Quit();

			}

			[Test]
			public void TestSearchFunctionResult()
			{
				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesTrueResult(Driver);

				SearchPage SearchModified = new SearchPage(Driver);

				SearchModified.SearchTestAllTickBoxesTrueResultPost(Driver);

				Driver.Quit();

			}

			[Test]
			public void TestSearchFunctionModifiedSearchButton()
			{
				Driver = new FirefoxDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search/modified");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesTrue(Driver);

				SearchPage SearchPost = new SearchPage(Driver);

				SearchPost.SearchTestAllTickBoxesTrueResultPost(Driver);



				Driver.Quit();

			}
		}

		class Edge
		{
			IWebDriver Driver;
			[Test]
			public void TestSearchFunctionAndTickboxAllFalseNoResult()
			{
				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesFalse(Driver);

				SearchPage SearchModified = new SearchPage(Driver);

				SearchModified.SearchTestAllTickBoxesFalsePost(Driver);

				Driver.Close();

			}

			[Test]
			public void TestSearchFunctionAndTickboxAllTrueNoResult()
			{
				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesTrueNoResult(Driver);

				SearchPage SearchModified = new SearchPage(Driver);

				SearchModified.SearchTestAllTicketBoxesTrueNoResultPost(Driver);

				Driver.Close();

			}

			[Test]
			public void TestSearchFunctionResult()
			{
				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesTrueResult(Driver);

				SearchPage SearchModified = new SearchPage(Driver);

				SearchModified.SearchTestAllTickBoxesTrueResultPost(Driver);

				Driver.Close();

			}

			[Test]
			public void TestSearchFunctionModifiedSearchButton()
			{
				Driver = new EdgeDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search/modified");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesTrue(Driver);

				SearchPage SearchPost = new SearchPage(Driver);

				SearchPost.SearchTestAllTickBoxesTrueResultPost(Driver);



				Driver.Close();

			}
		}

		class Safari
		{
			IWebDriver Driver;
			[Test]
			public void TestSearchFunctionAndTickboxAllFalseNoResult()
			{
				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesFalse(Driver);

				SearchPage SearchModified = new SearchPage(Driver);

				SearchModified.SearchTestAllTickBoxesFalsePost(Driver);

				Driver.Quit();

			}

			[Test]
			public void TestSearchFunctionAndTickboxAllTrueNoResult()
			{
				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesTrueNoResult(Driver);

				SearchPage SearchModified = new SearchPage(Driver);

				SearchModified.SearchTestAllTicketBoxesTrueNoResultPost(Driver);

				Driver.Quit();

			}

			[Test]
			public void TestSearchFunctionResult()
			{
				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesTrueResult(Driver);

				SearchPage SearchModified = new SearchPage(Driver);

				SearchModified.SearchTestAllTickBoxesTrueResultPost(Driver);

				Driver.Quit();

			}

			[Test]
			public void TestSearchFunctionModifiedSearchButton()
			{
				Driver = new SafariDriver();

				StandardPageModel PageModel = new StandardPageModel();

				PageModel.NavigateToPage(Driver, "https://lewiswhittard.co.uk/search/modified");

				SearchPage Search = new SearchPage(Driver);

				Search.SearchTestAllTickBoxesTrue(Driver);

				SearchPage SearchPost = new SearchPage(Driver);

				SearchPost.SearchTestAllTickBoxesTrueResultPost(Driver);



				Driver.Quit();

			}
		}
	}
}