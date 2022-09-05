public interface DiscountPolicy
{
    Money CalculateDiscountAmount(Screening screening);
}