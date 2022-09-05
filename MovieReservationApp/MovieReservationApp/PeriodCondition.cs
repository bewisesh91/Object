public class PeriodCondition : DiscountCondition
{
    private DayOfWeek dayOfWeek;
    private DateTime startTime;
    private DateTime endTime;

    public PeriodCondition(DayOfWeek dayOfWeek, DateTime startTime, DateTime endTime)
    {
        this.dayOfWeek = dayOfWeek;
        this.startTime = startTime;
        this.endTime = endTime;
    }

    public bool IsSatisfiedBy(Screening screening)
    {
        return screening.GetStartTime().DayOfWeek.Equals(dayOfWeek) && 
            startTime.CompareTo(screening.GetStartTime().ToLocalTime()) <= 0 && 
            endTime.CompareTo(screening.GetStartTime().ToLocalTime()) >= 0;
    }
}