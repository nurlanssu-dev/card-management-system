using CardManagementSystem.Enums;

namespace CardManagementSystem.Extensions;

public static class CardExtensions
{
    public static string MaskCardNumber(this Card card)
    {
        return $"{card.CardNumber[..4]} **** **** {card.CardNumber[^4..]}";
    }
    public static bool ExpenseWithBonus(this Card card, decimal amount)
    {
        bool result = card.WithDraw(amount);
        if (!result)
        {
            return false;
        }
        switch (card.Bank)
        {
            case Bank.ABB:
                card.Bonus += amount * 0.02m;
                break;

            case Bank.Leo:
                card.Bonus += amount * 0.04m;
                break;

            case Bank.KapitalBank:
                card.Bonus += amount * 0.05m;
                break;
        }
        return true;
    }
}
