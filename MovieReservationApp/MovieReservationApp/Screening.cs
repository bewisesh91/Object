public class Screening
{
    private Movie movie;
    private int sequence;
    private DateTime whenScreend;

    public Screening(Movie movie, int sequence, DateTime whenScreend)
    {
        this.movie = movie;
        this.sequence = sequence;
        this.whenScreend = whenScreend;
    }

    public Reservation Reserve(Customer customer, int audienceCount)
    {
        return new Reservation(customer, this, CalculateFee(audienceCount), audienceCount);
    }
    private Money CalculateFee(int audienceCount)
    {
        return movie.CalculateMovieFee(this).Times(audienceCount);
    }

    public DateTime GetStartTime()
    {
        return whenScreend;
    }

    public bool IsSequence(int sequence)
    {
        return this.sequence == sequence;
    }

    public Money GetMovieFee()
    {
        return movie.GetFee();
    }    
}