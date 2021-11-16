namespace McrDigital.Bootcamp1.Cards
{

    public class PlayingCardDeck : Deck
    {
        public PlayingCardDeck()
        {

            var result = new string[52];
            var deck = new PlayingCard[52];

            for (var suit = 0; suit < 4; suit++)
            {
                for (var faceValue = 0; faceValue < 13; faceValue++)
                {
                    var newCard = new PlayingCard(new Suit(suit), faceValue);
                    deck[suit * 13 + faceValue] = newCard;
                    cards.Add(newCard);
                }
            }

            var cardNumber = 0;
            foreach (var card in deck)
            {
                result[cardNumber] = $"{card.GetFaceValueName()} of {card.Suit.GetSuitName()}";
                cardNumber++;
            }
        }
    }
}