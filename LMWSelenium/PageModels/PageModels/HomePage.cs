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
using OpenQA.Selenium.Interactions;
using System.Threading;
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
		IWebElement LMWLogo { get; set; }
		IWebElement Linkedin { get; set; }

		public HomePage(IWebDriver driver)
		{
			HomeNavBarButton = FindElementById(driver, "HomeNavBarButton");
			SearchNavBarButton = FindElementById(driver, "SearchNavBarButton");
			ProgrammingButton = FindElementById(driver, "ProgrammingButton");
			TestingButton = FindElementById(driver, "TestingButton");
			GamesButton = FindElementById(driver, "GamesButton");
			ThreeDAssetsButton = FindElementById(driver, "ThreeDAssetsButton");
			TwoDBAssetsButton = FindElementById(driver, "TwoDAssetsButton");
			BlogButton = FindElementById(driver, "BlogButton");
			LMWLogo = FindElementById(driver, "LogoLink");
			Linkedin = FindElementById(driver, "Linkedin");
		}

		public void TestHomeNavBarButton(IWebDriver driver)
		{
			ClickButton(HomeNavBarButton);
			AssertAreEqual(driver.Title, "Home Page - Lewis Whittard Software Development");
		}

		public void TestSearchNavBarButton(IWebDriver driver)
		{
			ClickButton(SearchNavBarButton);
			WaitUntilURLContainsValue(driver, "search");
			AssertAreEqual(driver.Title, "Search - Lewis Whittard Software Development");
			
		}

		public void TestProgrammingButton(IWebDriver driver)
		{
			ClickButton(ProgrammingButton);
			WaitUntilURLContainsValue(driver, "Modified");
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");

		}

		public void TestTestButton(IWebDriver driver)
		{
			ClickButton(TestingButton);
			WaitUntilURLContainsValue(driver, "Modified");
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");
		}

		public void TestGamesButton(IWebDriver driver)
		{
			ClickButton(GamesButton);
			WaitUntilURLContainsValue(driver, "Modified");
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");
		}

		public void TestTwoDAssetsButton(IWebDriver driver)
		{
			ClickButton(TwoDBAssetsButton);
			WaitUntilURLContainsValue(driver, "Modified");
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");
		}

		public void TestThreeDAssetsButton(IWebDriver driver)
		{
			ClickButton(ThreeDAssetsButton);
			WaitUntilURLContainsValue(driver, "Modified");
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");
		}

		public void TestBlogButton(IWebDriver driver)
		{
			ClickButton(BlogButton);
			WaitUntilURLContainsValue(driver, "Modified");
			AssertAreEqual(driver.Title, "Search Modified - Lewis Whittard Software Development");
		}

		public void TestLogoButton(IWebDriver driver)
		{
			ClickButton(LMWLogo);
			AssertAreEqual(driver.Title, "Home Page - Lewis Whittard Software Development");
		}

		public void TestLinkedinButton(IWebDriver driver)
		{
			ClickButton(Linkedin);
			SwitchTab(driver, 1);
			WaitUntilURLContainsValue(driver, "https://www.linkedin.com/");
			AssertContains(driver.Url, "https://www.linkedin.com/");
			CloseDriver(driver);
			SwitchTab(driver, 0);
		}

	}
}
