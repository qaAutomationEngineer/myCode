using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FinalTask.UiElements
{
    public class MainPage : BasePage
    {
        public override string Url { get => "http://automationpractice.com/index.php"; }

        public Boolean IsSignInButtonExist()
        {
            try
            {
                return this.SignInButton.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public Boolean IsContactUsButtonExist()
        {
            try
            {
                return this.ContactUsButton.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public Boolean IsSearchFieldExist()
        {
            try
            {
                return this.SearchField.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public Boolean IsCartButtonExist()
        {
            try
            {
                return this.CartButton.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public Boolean IsStoreInformationExist()
        {
            try
            {
                return this.StoreInformation.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public Boolean IsLocationExist()
        {
            try
            {
                return this.Location.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public Boolean IsPhoneExist()
        {
            try
            {
                return this.Phone.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public Boolean IsEmailExist()
        {
            try
            {
                return this.Phone.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        [FindsBy(How = How.XPath, Using = "//a[@class=\"login\"]")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#contact-link > a")]
        public IWebElement ContactUsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class=\"shopping_cart\"]/a")]   
        public IWebElement CartButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#searchbox > button")]
        public IWebElement SubmitSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#search_query_top")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#block_contact_infos")]
        public IWebElement StoreInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"block_contact_infos\"]//i[@class=\"icon-map-marker\"]")]
        public IWebElement Location { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"block_contact_infos\"]//i[@class=\"icon-phone\"]")]
        public IWebElement Phone { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"block_contact_infos\"]//i[@class=\"icon-envelope-alt\"]")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#editorial_block_center > h1")]
        public IWebElement MainPageTxt { get; set; }

        public MainPage()
        {
            PageFactory.InitElements(Selenium.Driver, this);
        }
    }
}
