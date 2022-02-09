using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FinalTask.UiElements
{
    class OrderPage : BasePage
    {
        public override string Url { get => "http://automationpractice.com/index.php?controller=order"; }

        [FindsBy(How = How.CssSelector, Using = "#cart_title")]
        public IWebElement YourCartMsg { get; set; }

        public OrderPage()
        {
            PageFactory.InitElements(Selenium.Driver, this);
        }
    }
}
