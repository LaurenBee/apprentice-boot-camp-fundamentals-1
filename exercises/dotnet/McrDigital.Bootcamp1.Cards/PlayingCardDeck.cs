namespace McrDigital.Bootcamp1.Cards
{
    using System;

    public class PlayingCardDeck
    {
        public PlayingCardDeck()
        {
            var result = new string[52];
            var deck = new PlayingCard[52];

            for (var suit = 0; suit < 4; suit++)
            {
                for (var faceValue = 0; faceValue < 13; faceValue++)
                {
                    deck[suit * 13 + faceValue] = new PlayingCard(new Suit(suit), faceValue);
                }
            }

            var cardNumber = 0;
            foreach (var card in deck)
            {
                result[cardNumber] = $"{card.GetFaceValueName()} of {card.Suit.GetSuitName()}";
                cardNumber++;
            }

            playingCards = result;
        }

        private readonly string[] playingCards;

        public string[] GetCards()
        {
            return playingCards;
        }
    }
}