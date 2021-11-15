using Xunit;

namespace McrDigital.Bootcamp1.Cards.Tests
{
    public class SuitTest
    {
        [Fact]
        public void CanCreateSuit()
        {
            var suit = new Suit(1, "Diamonds");

            Assert.Equal(1, suit.Value);
            Assert.Equal("Diamonds", suit.Name);
        }
    }
}
