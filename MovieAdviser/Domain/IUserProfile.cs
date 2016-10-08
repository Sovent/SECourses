using System;

namespace MovieAdviser
{
    public interface IUserProfile
    {
        int Id { get; }

        string Email { get; }

        string FirstName { get; }

        string LastName { get; }

        WatchedMovie[] WatchedMovies { get; }

        WatchedMovie[] GetWatchedMoviesByPeriod(DateTime from, DateTime to);

        double GetMoviesAverageRating();

        double GetMoviesAverageRating(string specificGenre);

        void AddWatchedMovie(WatchedMovie watchedMovie);
    }
}