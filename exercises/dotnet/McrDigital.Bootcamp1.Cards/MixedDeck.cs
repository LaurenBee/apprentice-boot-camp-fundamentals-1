using System.Collections.Generic;
using System.Linq;

namespace McrDigital.Bootcamp1.Cards
{
    class MixedDeck : IDeck
    {
        private readonly List<ICard> cards;

        public MixedDeck()
        {
            var animalDeck = new AnimalDeck();
            var playingCardDeck = new PlayingCardDeck();

            cards.AddRange(animalDeck.GetAllCards());
            cards.AddRange(playingCardDeck.GetAllCards());
        }

        public ICard Deal()
        {
            var card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public ICard[] GetAllCards()
        {
            throw new System.NotImplementedException();
        }

        public string[] GetCards()
        {
            return cards.Select(_ => _.ToString()).ToArray();
        }

        public void Shuffle()
        {
           cards.KnuthShuffle();
        }
    }
}
