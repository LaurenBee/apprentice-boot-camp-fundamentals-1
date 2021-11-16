namespace McrDigital.Bootcamp1.Cards
{
    using System.Linq;
    using System.Collections.Generic;

    public class PlayingCardDeck : IDeck
    {
        public PlayingCardDeck()
        {
            playingCards = new List<PlayingCard>();

            var result = new string[52];
            var deck = new PlayingCard[52];

            for (var suit = 0; suit < 4; suit++)
            {
                for (var faceValue = 0; faceValue < 13; faceValue++)
                {
                    var newCard = new PlayingCard(new Suit(suit), faceValue);
                    deck[suit * 13 + faceValue] = newCard;
                    playingCards.Add(newCard);
                }
            }

            var cardNumber = 0;
            foreach (var card in deck)
            {
                result[cardNumber] = $"{card.GetFaceValueName()} of {card.Suit.GetSuitName()}";
                cardNumber++;
            }
        }

        private readonly List<PlayingCard> playingCards;

        public string[] GetCards()
        {
            return playingCards.Select(_ => _.ToString()).ToArray();
        }

        public ICard Deal()
        {
            var card = playingCards[0];
            playingCards.RemoveAt(0);
            return card;
        }

        public void Shuffle()
        {
            playingCards.KnuthShuffle(); ;
        }
    }
}