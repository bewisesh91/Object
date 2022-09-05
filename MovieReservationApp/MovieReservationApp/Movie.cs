public class Movie
{
    private string title;
    private Duration runningTime;
    private Money fee;
    private DiscountPolicy discountPolicy;
    public Movie(string title, Duration runningTime, Money fee, DiscountPolicy discountPolicy)
    {
        this.title = title;
        this.runningTime = runningTime;
        this.fee = fee;
        this.discountPolicy = discountPolicy;
    }

    public Money GetFee()
    {
        return fee;
    }

    public Money CalculateMovieFee(Screening screening)
    {
        return fee.Minus(discountPolicy.CalculateDiscountAmount(screening));
    }

    public void ChangeDiscountPolicy(DiscountPolicy discountPolicy)
    {
        this.discountPolicy = discountPolicy;
    }
}