namespace McrDigital.Bootcamp1.Cards
{
    public class Suit
    {
        public Suit(int value, string name)
        {
            this.Value = value;
            this.Name = name;
        }

        public int Value { get; }
        public string Name { get; }
    }
}
