using BlazorApp.Pages;
using Bunit;
using NUnit.Framework;

namespace UnitTests.Components
{
    public class CounterTests : BunitTestContext
    {
        [Test]
        public void CounterShouldIncrementWhenSelected()
        {
            // Arrange
            var cut = RenderComponent<Counter>();
            var pEl = cut.Find("p");

            // Act
            cut.Find("button").Click();
            var paraElmText = pEl.TextContent;

            // Assert
            paraElmText.MarkupMatches("Current count: 1");
        }
    }
}