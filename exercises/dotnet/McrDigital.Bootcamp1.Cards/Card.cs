namespace McrDigital.Bootcamp1.Cards
{
    public class Card
    {
        public bool Snap(Card card)
        {
            return this.ToString() == card.ToString();
        }
    }
}
