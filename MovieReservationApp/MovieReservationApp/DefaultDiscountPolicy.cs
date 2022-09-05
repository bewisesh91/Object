public abstract class DefaultDiscountPolicy : DiscountPolicy
{
    private List<DiscountCondition> conditions = new List<DiscountCondition>();

    public DefaultDiscountPolicy(params DiscountCondition[] conditions)
    {
        this.conditions = conditions.ToList();
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