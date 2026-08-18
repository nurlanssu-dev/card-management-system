namespace CardManagementSystem;

public class DebitCard : Card
{
    public override bool WithDraw(decimal amount)
    {
        if (amount <= 0)
            return false;
        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"DebitCard -> Id: {Id}, Balance: {Balance}, Bonus: {Bonus}, CardNumber: {CardNumber}, Bank: {Bank}";
    }
}