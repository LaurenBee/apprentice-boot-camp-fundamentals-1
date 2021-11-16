namespace McrDigital.Bootcamp1.Cards
{
    public interface ICard
    {
        string GetDescription();
        bool Snap(ICard card);
    }
}
