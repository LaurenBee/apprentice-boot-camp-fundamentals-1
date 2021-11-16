using System.Collections.Generic;
using System.Linq;

namespace McrDigital.Bootcamp1.Cards
{
    public class Deck
    {
        public Deck()
        {
            cards = new List<Card>();
        }

        public List<Card> cards;

        public string[] GetCards()
        {
            return cards.Select(_ => _.ToString()).ToArray();
        }

        public Card Deal()
        {
            var card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
        public void Shuffle()
        {
            cards.KnuthShuffle();
        }
    }
}
