namespace McrDigital.Bootcamp1.Cards
{
    using System;
    using System.Collections.Generic;

    public abstract class AnimalDeck : Deck
    {
        public AnimalDeck()
        {
            foreach (Animal animal in Enum.GetValues(typeof(Animal)))
            {
                cards.Add(new AnimalCard(animal));
                cards.Add(new AnimalCard(animal));
            }
        }
    }
}