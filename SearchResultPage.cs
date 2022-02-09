using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FinalTask.UiElements
{
    class SearchResultPage : BasePage
    {
        public override string Url { get => "http://automationpractice.com/index.php?controller=search&orderby=position&orderway=desc&search_query"; }

        [FindsBy(How = How.ClassName, Using = "lighter")]
        public IWebElement SearchResult { get; set; }

        public SearchResultPage()
        {
            PageFactory.InitElements(Selenium.Driver, this);
        }
    }
}
