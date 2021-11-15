namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCard
    {
        public PlayingCard(int suit, int faceValue)
        {
            this.Suit = suit;
            this.FaceValue = faceValue;
        }
        public int Suit { get; }
        public int FaceValue { get; }
    }
}
