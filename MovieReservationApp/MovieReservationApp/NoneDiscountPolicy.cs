public class NoneDiscountPolicy : DiscountPolicy
{
    public Money CalculateDiscountAmount(Screening screening)
    {
        return Money.ZERO;
    }
}