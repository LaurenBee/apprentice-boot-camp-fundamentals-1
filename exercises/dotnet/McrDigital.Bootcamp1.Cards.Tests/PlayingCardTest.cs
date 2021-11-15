using Xunit;

namespace McrDigital.Bootcamp1.Cards.Tests
{
    public class PlayingCardTest
    {
        [Fact]
        public void CanCreatePlayingCard ()
        {
            var playingCard = new PlayingCard(0, 2);

            Assert.Equal(0, playingCard.Suit);
            Assert.Equal(2, playingCard.FaceValue);
        }
    }
}
