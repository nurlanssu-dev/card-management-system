namespace CardManagementSystem;

public class CardService : ICardService

{
    private static Card[] _cards = new Card[0];

    public void AddCard(Card card)
    {
        for (int i = 0; i < _cards.Length; i++)
        {
            if (_cards[i].CardNumber == card.CardNumber)
            {
                Console.WriteLine("Bu kart artıq mövcuddur.");
                return;
            }
        }
        Card[] newCard = new Card[_cards.Length + 1];
        for (int i = 0; i < _cards.Length; i++)
        {
            newCard[i] = _cards[i];
        }
        newCard[newCard.Length - 1] = card;
        _cards = newCard;
    }

    public Card GetCardByNumber(string cardNumber)
    {
        for (int i = 0; i < _cards.Length; i++)
        {
            if (_cards[i].CardNumber == cardNumber)
            {
                return _cards[i];
            }
        }

        return null;
    }
}        

