using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FinalTask.UiElements
{
    class ContactUsPage : BasePage
    {
        public override string Url { get => "http://automationpractice.com/index.php?controller=contact"; }

        [FindsBy(How = How.CssSelector, Using = "#center_column > h1")]
        public IWebElement ContactUsTxt { get; set; }

        public ContactUsPage()
        {
            PageFactory.InitElements(Selenium.Driver, this);
        }
    }
}
