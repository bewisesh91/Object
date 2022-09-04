public class AmountDiscountPolicy : DiscountPolicy
{
    private Money discountAmount;
    public AmountDiscountPolicy(Money discountAmount, List<DiscountCondition> conditions) : base(conditions)
    {
        this.discountAmount = discountAmount;
    }

    protected override Money GetDiscountAmount(Screening screening)
    {
        return discountAmount;
    }
}