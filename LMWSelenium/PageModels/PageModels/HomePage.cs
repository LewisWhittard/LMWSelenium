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
	class HomePage:StandardPageModel
	{
		IWebElement HomeNavBarButton { get; set; }
		IWebElement SearchNavBarButton { get; set; }
		IWebElement ProgrammingButton { get; set; }
		IWebElement TestButton { get; set; }
		IWebElement GamesButton { get; set; }
		IWebElement ThreeDAssetsButton { get; set; }
		IWebElement TwoDBAssetsButton { get; set; }
		IWebElement 
		
		public HomePage(WebDriver driver)
		{
			ProgrammingButton = 
		}
	}
}
