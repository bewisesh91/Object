public abstract class DiscountPolicy
{
    private List<DiscountCondition> conditions = new List<DiscountCondition>();

    public DiscountPolicy(List<DiscountCondition> conditions)
    {
        this.conditions = conditions;
    }

    public Money CalculateDiscountAmount(Screening screening)
    {
        foreach (var condition in conditions)
        {
            if (condition.IsSatisfiedBy(screening))
            {
                return GetDiscountAmount(screening);
            }
        }
        return Money.ZERO;
    }

    abstract protected Money GetDiscountAmount(Screening screening);
}