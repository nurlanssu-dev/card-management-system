namespace CardManagementSystem;

public class CreditCard : Card
{
    private decimal _creditLimit;
    public decimal Limit
    {
        get

        { return _creditLimit; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("limit musbet olmalidir");
            }
            else
            {
                _creditLimit = value;
            }
        }
    }
    public override bool WithDraw(decimal amount)
    {
        if (amount <= 0)
            return false;

        if (Balance + Limit < amount)
            return false;

        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }

        decimal missingAmount = amount - Balance;

        Balance = 0;
        Limit -= missingAmount;

        return true;
    }
    public override string ToString()
    {
       return $"Id: {Id}, Balance: {Balance}, Bonus: {Bonus}, CardNumber: {CardNumber}, Bank: {Bank}";
    }

}
