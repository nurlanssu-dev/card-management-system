using CardManagementSystem.Enums;

namespace CardManagementSystem;

internal class Program
{
    static void Main(string[] args)
    {
        DebitCard debitCard = new DebitCard
        {
            Id = 1,
            Balance = 1000,
            Bonus = 0,
            CardNumber = "1234567812345678",
            Bank = Bank.ABB
        };
        CreditCard creditCard = new CreditCard
        {
            Id = 2,
            Balance = 500,
            Bonus = 0,
            CardNumber = "9876543219876543",
            Bank = Bank.Leo,
            Limit = 1000
        };
        Console.WriteLine(debitCard);
        Console.WriteLine(creditCard);

        CardService service = new CardService();

        service.AddCard(debitCard);
        service.AddCard(creditCard);

        Card searchCard = service.GetCardByNumber("1234567812345678");

        if (searchCard != null)
        {
            Console.WriteLine(searchCard);
        }
        else
        {
            Console.WriteLine("Kart tapılmadı.");
        }


    }
}
