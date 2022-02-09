using System;
using OpenQA.Selenium;

namespace FinalTask.UiElements
{
    public abstract class BasePage
    {
        public abstract string Url { get; }

        public void Open()
        {
            Selenium.Driver.Navigate().GoToUrl(Url);
        }
    }
}
