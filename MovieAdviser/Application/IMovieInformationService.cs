using System;

namespace MovieAdviser
{
    public interface IMovieInformationService
    {
        double GetAverageMoviesRating(int userId);

        double GetAverageMoviesRating(int userId, string specificGenre);
        
        WatchedMovie[] GetWatchedMoviesByPeriod(int userId, DateTime @from, DateTime to);
    }
}