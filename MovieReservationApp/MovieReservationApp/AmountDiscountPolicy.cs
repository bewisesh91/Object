public class AmountDiscountPolicy : DefaultDiscountPolicy
{
    private Money discountAmount;
    public AmountDiscountPolicy(Money discountAmount, params DiscountCondition[] conditions) : base(conditions)
    {
        this.discountAmount = discountAmount;
    }

    protected override Money GetDiscountAmount(Screening screening)
    {
        return discountAmount;
    }
}