using FinalTask.UiElements;
using NUnit.Framework;

namespace FinalTask.Tests
{
    public class TestsMainPage
    {

        [OneTimeTearDown]
        public void AfterAlltests()
        {
            Selenium.Driver.Quit();
        }

        [Test]
        public void AсcessToMainPage()
        {
            string expectedMainPageText = "Automation Practice Website";
            string expectedUrl = "http://automationpractice.com/index.php";
            MainPage mainPage = new MainPage();
            mainPage.Open();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedMainPageText, mainPage.MainPageTxt.Text, "Wrong main page text!");
                Assert.AreEqual(expectedUrl, mainPage.Url, "This is not a main page");
            });
        }

        [Test]
        public void SignInButtonExistAndEnabled()
        {
            MainPage mainPage = new MainPage();
            mainPage.Open();

            Assert.Multiple(() =>
            {
                Assert.IsTrue(mainPage.IsSignInButtonExist(), "Sign in button is not exist");
                Assert.IsTrue(mainPage.SignInButton.Enabled, "Sign in button is disabled");
            });
        }

        [Test]
        public void UnregisteredUsersClickSignInButton()
        {
            string expectedSignUpMessage = "CREATE AN ACCOUNT";
            string expectedSignInMessage = "ALREADY REGISTERED?";

            MainPage mainPage = new MainPage();
            mainPage.Open();
            mainPage.SignInButton.Click();
            LoginPage loginPage = new LoginPage();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedSignUpMessage, loginPage.SignUpMsg.Text, "Wrong sign up message!");
                Assert.AreEqual(expectedSignInMessage, loginPage.SignInMsg.Text, "Wrong sign in message!");
            });
        }

        [Test]
        public void ContactUsButtonIsExistAndEnabled()
        {
            MainPage mainPage = new MainPage();
            mainPage.Open();

            Assert.Multiple(() =>
            {
                Assert.IsTrue(mainPage.IsContactUsButtonExist(), "Contact us button is not exist");
                Assert.IsTrue(mainPage.ContactUsButton.Enabled, "Contact us button is disabled");
            });
        }

        [Test]
        public void UnregisteredUsersClickContactUsButton()
        {
            string expectedContactUsText = "CUSTOMER SERVICE - CONTACT US";
            MainPage mainPage = new MainPage();
            mainPage.Open();
            mainPage.ContactUsButton.Click();
            ContactUsPage contactUsPage = new ContactUsPage();

            Assert.AreEqual(expectedContactUsText, contactUsPage.ContactUsTxt.Text, "Wrong contact us text.");
        }

        [Test]
        public void CartButtonIsExistAndEnabled()
        {
            MainPage mainPage = new MainPage();
            mainPage.Open();

            Assert.Multiple(() =>
            {
                Assert.IsTrue(mainPage.IsCartButtonExist(), "Cart button is not exist");
                Assert.IsTrue(mainPage.CartButton.Enabled, "Cart button is disabled");
            });
        }

        [Test]
        public void UnregisteredUsersClickCartButton()
        {
            string expectedCartMsg = "SHOPPING-CART SUMMARY";
            MainPage mainPage = new MainPage();
            mainPage.Open();
            mainPage.CartButton.Click();
            OrderPage orderPage = new OrderPage();

            Assert.AreEqual(expectedCartMsg, orderPage.YourCartMsg.Text, "Wrong cart text.");
        }

        [Test]
        public void SearchFieldIsExistAndEnabled()
        {
            MainPage mainPage = new MainPage();
            mainPage.Open();

            Assert.Multiple(() =>
            {
                Assert.IsTrue(mainPage.IsSearchFieldExist(), "Search field is not exist");
                Assert.IsTrue(mainPage.SearchField.Enabled, "Search field is disabled");
            });
        }

        [Test]
        public void UnregisteredUsersUseSearch()
        {
            string searchRequest = "printed dress";
            MainPage mainPage = new MainPage();
            mainPage.Open();
            mainPage.SearchField.SendKeys(searchRequest);
            mainPage.SubmitSearch.Click();
            SearchResultPage searchResultPage = new SearchResultPage();

            Assert.AreEqual(searchRequest.ToUpper(), searchResultPage.SearchResult.Text.Replace("\"", ""), "Wrong search result.");
        }

        [Test]
        public void StoreInformationIsExistAndEnabled()
        {
            MainPage mainPage = new MainPage();
            mainPage.Open();

            Assert.Multiple(() =>
            {
                Assert.IsTrue(mainPage.IsStoreInformationExist(), "Store information is not exist");
                Assert.IsTrue(mainPage.StoreInformation.Enabled, "Store information is disabled");
                Assert.IsTrue(mainPage.IsLocationExist(), "Location is not exist");
                Assert.IsTrue(mainPage.IsEmailExist(), "Email is not exist");
                Assert.IsTrue(mainPage.IsPhoneExist(), "Phone is not exist");
            });
        }
    }
}
