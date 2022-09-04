public class PercentDiscountPolicy : DiscountPolicy
{
    private double percent;
    public PercentDiscountPolicy(double percent, List<DiscountCondition> conditions) : base(conditions)
    {
        this.percent = percent;
    }

    protected override Money GetDiscountAmount(Screening screening)
    {
        return screening.GetMovieFee().Times(percent);
    }
}