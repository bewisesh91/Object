public class PeriodCondition : DiscountCondition
{
    private int sequence;

    public PeriodCondition(int sequence)
    {
        this.sequence = sequence;
    }
    public bool IsSatisfiedBy(Screening screening)
    {
        return screening.IsSequence(sequence);
    }
}