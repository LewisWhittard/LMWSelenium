using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Safari;
using LMWSelenium.PageModels.StandardPage;
//using NUnit.Framework;

namespace LMWSelenium.PageModels.PageModels
{
	class HomePage : StandardPageModel
	{
		IWebElement HomeNavBarButton { get; set; }
		IWebElement SearchNavBarButton { get; set; }
		IWebElement ProgrammingButton { get; set; }
		IWebElement TestingButton { get; set; }
		IWebElement GamesButton { get; set; }
		IWebElement ThreeDAssetsButton { get; set; }
		IWebElement TwoDBAssetsButton { get; set; }
		IWebElement BlogButton { get; set; }

		public HomePage(IWebDriver driver)
		{
			NavigateToPage(driver, "https://www.lewiswhittard.co.uk");
			HomeNavBarButton = FindElementById(driver, "HomeNavBarButton");
			SearchNavBarButton = FindElementById(driver, "SearchNavBarButton");
			ProgrammingButton = FindElementById(driver, "ProgrammingButton");
			TestingButton = FindElementById(driver, "TestingButton");
			GamesButton = FindElementById(driver, "GamesButton");
			ThreeDAssetsButton = FindElementById(driver, "ThreeDAssetsButton");
			TwoDBAssetsButton = FindElementById(driver, "TwoDAssetsButton");
			BlogButton = FindElementById(driver, "BlogButton");
		}

		public void TestHomeNavBarButton(IWebDriver driver)
		{
			ClickButton(HomeNavBarButton);
			AssertAreEqual(driver.Title, "Home Page - Lewis Whittard Software Development");
		}

		public void TestSearchNavBarButton(IWebDriver driver)
		{
			ClickButton(SearchNavBarButton);
			AssertAreEqual(driver.Title, "Search - Lewis Whittard Software Development");
			
		}

		public void TestProgrammingButton(IWebDriver driver)
		{
			ClickButton(ProgrammingButton);
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");

		}

		public void TestTestButton(IWebDriver driver)
		{
			ClickButton(TestingButton);
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");
		}

		public void TestGamesButton(IWebDriver driver)
		{
			ClickButton(GamesButton);
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");
		}

		public void TestTwoDAssetsButton(IWebDriver driver)
		{
			ClickButton(TwoDBAssetsButton);
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");
		}

		public void TestThreeDAssetsButton(IWebDriver driver)
		{
			ClickButton(ThreeDAssetsButton);
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");
		}

		public void TestBlogButton(IWebDriver driver)
		{
			ClickButton(BlogButton);
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");
		}

	}
}
