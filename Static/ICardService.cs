namespace CardManagementSystem;

public interface ICardService
{
    void AddCard(Card card);
    Card GetCardByNumber(string cardNumber);
}
