using BlazorApp.Pages;
using Bunit;
using NUnit.Framework;

namespace UnitTests.Components
{
    public class CounterTests : BunitTestBase
    {
        [Test]
        public void CounterShouldIncrementWhenSelected()
        {
            // Arrange
            IRenderedComponent<Counter> cut = RenderComponent<Counter>();
            AngleSharp.Dom.IElement pEl = cut.Find("p");

            // Act
            cut.Find("button").Click();
            string paraElmText = pEl.TextContent;

            // Assert
            paraElmText.MarkupMatches("Current count: 1");
        }
    }
}