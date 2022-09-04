public class SequenceCondition : DiscountCondition
{
    private int sequence;

    public SequenceCondition(int sequence)
    {
        this.sequence = sequence;
    }
    public bool IsSatisfiedBy(Screening screening)
    {
        return screening.IsSequence(sequence);
    }
}