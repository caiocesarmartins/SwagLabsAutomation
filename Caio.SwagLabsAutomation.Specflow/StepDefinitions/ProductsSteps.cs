using Caio.SwagLabsAutomation.PageObjects;
using Caio.SwagLabsAutomation.Shared.Models;
using FluentAssertions.Execution;
using OpenQA.Selenium;

namespace Caio.SwagLabsAutomation.Specflow.StepDefinitions
{
    [Binding]
    public sealed class ProductsSteps : Steps
    {
        private readonly ProductsPage _productsPage;

        public ProductsSteps(IWebDriver driver, RootUrl rootUrl, ProductsPage productsPage) : base(driver, rootUrl)
        {
            _productsPage = productsPage;
        }

        [Then(@"I am in the Products page")]
        public void ThenIAmInTheProductsPage()
        {
            using (new AssertionScope())
            {
                Driver.Url.Should().EndWith("inventory.html");
                _productsPage.Header.Text.Should().Be("PRODUCTS");
            }
        }
    }
}