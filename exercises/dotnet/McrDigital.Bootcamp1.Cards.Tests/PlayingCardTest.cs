using Xunit;

namespace McrDigital.Bootcamp1.Cards.Tests
{
    public class PlayingCardTest
    {
        [Fact]
        public void CanCreatePlayingCard ()
        {
            var playingCard = new PlayingCard(new Suit(0), 2);

            Assert.Equal(0, playingCard.Suit.Value);
            Assert.Equal(2, playingCard.FaceValue);
        }
    }
}
