namespace MovieRental
{
    public abstract class MovieBase
    {
        public MovieBase(string title)
        {
            Title = title;
        }

        public string Title { get; }

        public abstract double RegularPrice {get;}

        public abstract bool AreBonusesAvailable { get; }
        
        public override string ToString()
        {
            return Title;
        }
    }
}