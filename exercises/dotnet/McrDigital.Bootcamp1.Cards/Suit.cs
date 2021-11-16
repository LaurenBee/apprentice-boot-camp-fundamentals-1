using System;

namespace McrDigital.Bootcamp1.Cards
{
    public class Suit
    {
        public Suit(int value)
        {
            this.Value = value;
        }

        public int Value { get; }

        public string GetSuitName()
        {
            switch (Value)
            {
                case 0:
                    return "clubs";
                case 1:
                    return "diamonds";
                case 2:
                    return "hearts";
                case 3:
                    return "spades";
                default: throw new ArgumentException($"Something went wrong {Value} is not a valid suitName!");
            }
        }
    }
}
