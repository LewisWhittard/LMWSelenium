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

namespace LMWSelenium.PageModels.StandardPage
{
	class StandardPageModel
	{
		public void NavigateToPage(IWebDriver driver, String url)
		{
			driver.Navigate().GoToUrl(url);
		}

		public IWebElement FindElementById(IWebDriver driver, string id)
		{
			try
			{
				IWebElement ReturnElement = driver.FindElement(By.Id(id));
			}
			catch (Exception)
			{

				throw;
			}
			

			return null;
		}
		
		public void ClickButton(IWebElement button)
		{
			button.Click();
		}

		public string CheckTickBoxValue(IWebElement tickbox)
		{
			string TickboxValue = tickbox.GetAttribute("checked");

			return TickboxValue;
		}

	}
}
