using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using LMWSelenium.PageModels.StandardPage;
using NUnit.Framework;

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

		public void TestSearchNavBarButton(IWebDriver driver)
		{
			ClickButton(SearchNavBarButton);
			Assert.AreEqual(driver.Title, "Search - Lewis Whittard Software Development");
		}

	}
}
