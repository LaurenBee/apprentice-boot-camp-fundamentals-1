namespace McrDigital.Bootcamp1.Cards
{
    public interface IDeck
    {
        string[] GetCards();
        ICard[] GetAllCards();
        ICard Deal();
        void Shuffle();
    }
}
