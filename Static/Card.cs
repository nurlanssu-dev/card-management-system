using CardManagementSystem.Enums;

namespace CardManagementSystem;

public abstract class Card
{
    public int Id { get; set; }
    public decimal Balance { get; set; }
    public decimal Bonus { get; set; }
    private string _cardNumber;
    public string CardNumber
    {
        get { return _cardNumber; }
        set
        {
            if (value.Length != 16)
            {
                Console.WriteLine("Card number 16 reqemli olmalidir.");
            }
            _cardNumber = value;
        }
    }
    public Bank Bank { get; set; }
    public abstract bool WithDraw(decimal amount);
}
