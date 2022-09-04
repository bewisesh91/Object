public class Money
{
    public static Money ZERO = Wons(0);

    private decimal amount;

    public Money(decimal amount)
    {
        this.amount = amount;
    }

    public static Money Wons(long amount)
    {
        return new Money((decimal)amount);
    }

    public static Money Wons(double amount)
    {
        return new Money((decimal)amount);
    }

    public Money Plus(Money amount)
    {
        return new Money(this.amount + amount.amount);
    }

    public Money Minus(Money amount)
    {
        return new Money(this.amount - amount.amount);
    }

    public Money Times(double percent)
    {
        return new Money(this.amount * (decimal)percent);
    }

    public bool IsLessThan(Money other)
    {
        return amount.CompareTo(other.amount) < 0;
    }

    public bool IsGreaterThan(Money other)
    {
        return amount.CompareTo(other.amount) > 0;
    }
}

