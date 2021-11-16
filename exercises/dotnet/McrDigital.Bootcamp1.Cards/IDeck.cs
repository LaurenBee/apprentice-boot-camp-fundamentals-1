namespace McrDigital.Bootcamp1.Cards
{
    public interface IDeck
    {
        string[] GetCards();

        ICard Deal();
        void Shuffle();
    }
}
