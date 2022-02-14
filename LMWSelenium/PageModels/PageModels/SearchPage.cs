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

namespace LMWSelenium.PageModels.PageModels
{
	class SearchPage:StandardPageModel
	{
		IWebElement SearchBox { get; set; }
		IWebElement SearchButton { get; set; }
		IWebElement ProgrammingTickBox { get; set; }
		IWebElement TestingTickBox { get; set; }
		IWebElement GamesTickBox { get; set; }
		IWebElement ThreeDAssetsTickBox { get; set; }
		IWebElement TwoDAssetsTickBox { get; set; }
		IWebElement BlogTickBox { get; set; }

		public SearchPage(IWebDriver driver)
		{
			SearchBox = FindElementById(driver, "Search");
			SearchButton = FindElementById(driver, "SearchButton");
			ProgrammingTickBox = FindElementById(driver, "Programming");
			TwoDAssetsTickBox = FindElementById(driver, "TwoDAssets");
			ThreeDAssetsTickBox = FindElementById(driver, "ThreeDAssets");
			TestingTickBox = FindElementById(driver, "Testing");
			GamesTickBox = FindElementById(driver, "Games");
			BlogTickBox = FindElementById(driver, "Blog");


		}
		
		public void CheckSearchButtonPost()
		{
			CheckTickBoxValueIsTrue(ProgrammingTickBox);
			CheckTickBoxValueIsTrue(TestingTickBox);
			CheckTickBoxValueIsTrue(GamesTickBox);
			CheckTickBoxValueIsTrue(ThreeDAssetsTickBox);
			CheckTickBoxValueIsTrue(TwoDAssetsTickBox);
			CheckTickBoxValueIsTrue(BlogTickBox);
		}

		public void CheckProgrammingButtonPost()
		{
			CheckTickBoxValueIsTrue(ProgrammingTickBox);
			CheckTickBoxValueIsFalse(TestingTickBox);
			CheckTickBoxValueIsFalse(GamesTickBox);
			CheckTickBoxValueIsFalse(ThreeDAssetsTickBox);
			CheckTickBoxValueIsFalse(TwoDAssetsTickBox);
			CheckTickBoxValueIsFalse(BlogTickBox);

		}

		public void CheckTestingButtonPost()
		{
			CheckTickBoxValueIsFalse(ProgrammingTickBox);
			CheckTickBoxValueIsTrue(TestingTickBox);
			CheckTickBoxValueIsFalse(GamesTickBox);
			CheckTickBoxValueIsFalse(ThreeDAssetsTickBox);
			CheckTickBoxValueIsFalse(TwoDAssetsTickBox);
			CheckTickBoxValueIsFalse(BlogTickBox);
		}

		public void CheckGamesButtonPost()
		{
			CheckTickBoxValueIsFalse(ProgrammingTickBox);
			CheckTickBoxValueIsFalse(TestingTickBox);
			CheckTickBoxValueIsTrue(GamesTickBox);
			CheckTickBoxValueIsFalse(ThreeDAssetsTickBox);
			CheckTickBoxValueIsFalse(TwoDAssetsTickBox);
			CheckTickBoxValueIsFalse(BlogTickBox);
		}

		public void CheckThreeDButtonPost()
		{
			CheckTickBoxValueIsFalse(ProgrammingTickBox);
			CheckTickBoxValueIsFalse(TestingTickBox);
			CheckTickBoxValueIsFalse(GamesTickBox);
			CheckTickBoxValueIsTrue(ThreeDAssetsTickBox);
			CheckTickBoxValueIsFalse(TwoDAssetsTickBox);
			CheckTickBoxValueIsFalse(BlogTickBox);
		}

		public void CheckTwoDButtonPost()
		{
			CheckTickBoxValueIsFalse(ProgrammingTickBox);
			CheckTickBoxValueIsFalse(TestingTickBox);
			CheckTickBoxValueIsFalse(GamesTickBox);
			CheckTickBoxValueIsFalse(ThreeDAssetsTickBox);
			CheckTickBoxValueIsTrue(TwoDAssetsTickBox);
			CheckTickBoxValueIsFalse(BlogTickBox);
		}

		public void BlogButtonPost()
		{
			CheckTickBoxValueIsFalse(ProgrammingTickBox);
			CheckTickBoxValueIsFalse(TestingTickBox);
			CheckTickBoxValueIsFalse(GamesTickBox);
			CheckTickBoxValueIsFalse(ThreeDAssetsTickBox);
			CheckTickBoxValueIsFalse(TwoDAssetsTickBox);
			CheckTickBoxValueIsTrue(BlogTickBox);
		}


	}
}
