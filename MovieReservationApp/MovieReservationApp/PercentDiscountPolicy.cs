public class PercentDiscountPolicy : DefaultDiscountPolicy
{
    private double percent;
    public PercentDiscountPolicy(double percent, params DiscountCondition[] conditions) : base(conditions)
    {
        this.percent = percent;
    }

    protected override Money GetDiscountAmount(Screening screening)
    {
        return screening.GetMovieFee().Times(percent);
    }
}