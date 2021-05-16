namespace MovieRental
{
    internal class Rental
    {
        public Rental(MovieBase movie, int daysRental)
        {
            Movie = movie;
            DaysRental = daysRental;
        }

        internal MovieBase Movie { get; }

        internal int DaysRental { get; }
    }
}