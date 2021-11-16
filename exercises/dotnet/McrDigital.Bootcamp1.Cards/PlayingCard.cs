using System;

namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCard : Card
    {
        public PlayingCard(Suit suit, int faceValue)
        {
            this.Suit = suit;
            this.FaceValue = faceValue;
        }
        public Suit Suit { get; }
        public int FaceValue { get; }

        public override string ToString()
        {
            return $"{this.GetFaceValueName()} of {this.Suit.GetSuitName()}";
        }

        public string GetFaceValueName()
        {
            switch (FaceValue)
            {
                case 0:
                    return "ace";
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    return (FaceValue + 1).ToString();
                case 10:
                    return "jack";
                case 11:
                    return "queen";
                case 12:
                    return "king";
                default: throw new ArgumentException($"Something went wrong {FaceValue} is not a valid faceValue!");
            }
        }
    }
}
