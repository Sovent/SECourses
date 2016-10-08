using System;

namespace MovieAdviser
{
    public class WatchedMovie
    {
        public WatchedMovie(Movie movie, double rating, DateTime watchedDate)
        {
            Movie = movie;
            Rating = rating;
            WatchedDate = watchedDate;
        }

        public Movie Movie { get; private set; } 

        public double Rating { get; private set; }

        public DateTime WatchedDate { get; private set; }
    }
}