using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FinalTask.UiElements
{
    class LoginPage: BasePage
    {
        public override string Url { get => "http://automationpractice.com/index.php?controller=authentication&back=my-account"; }

        [FindsBy(How = How.CssSelector, Using = "#create-account_form > h3")]
        public IWebElement SignUpMsg { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login_form > h3")]
        public IWebElement SignInMsg { get; set; }

        public LoginPage()
        {
            PageFactory.InitElements(Selenium.Driver, this);
        }
    }
}
