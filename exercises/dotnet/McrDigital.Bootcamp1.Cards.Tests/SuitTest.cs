using Xunit;

namespace McrDigital.Bootcamp1.Cards.Tests
{
    public class SuitTest
    {
        [Fact]
        public void CanCreateSuit()
        {
            var suit = new Suit(1);

            Assert.Equal(1, suit.Value);
            Assert.Equal("diamonds", suit.GetSuitName());
        }
    }
}
