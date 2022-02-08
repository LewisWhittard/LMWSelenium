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
			TestingTickBox = FindElementById(driver, "Testing");
			GamesTickBox = FindElementById(driver, "Games");


		}
		
		public SearchPage()
		{

		}

		

	}
}
