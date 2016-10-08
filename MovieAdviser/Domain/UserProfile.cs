using System;
using System.Collections.Generic;

namespace MovieAdviser
{
    public class UserProfile : IUserProfile
    {
        public UserProfile(
            int id, 
            string email, 
            string firstName, 
            string lastName, 
            WatchedMovie[] watchedMovies)
        {
            Id = id;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            _watchedMovies = new List<WatchedMovie>(watchedMovies ?? new WatchedMovie[0]);
        }

        public int Id { get; private set; }

        public string Email { get; private set; } 

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public WatchedMovie[] WatchedMovies
        {
            get
            {
                return _watchedMovies.ToArray();
            }
        }

        public WatchedMovie[] GetWatchedMoviesByPeriod(DateTime from, DateTime to)
        {
            var watchedMoviesInPeriod = new List<WatchedMovie>();
            foreach (var watchedMovie in _watchedMovies)
            {
                if (watchedMovie.WatchedDate >= from && watchedMovie.WatchedDate <= to)
                {
                    watchedMoviesInPeriod.Add(watchedMovie);
                }
            }
            return watchedMoviesInPeriod.ToArray();
        }

        public double GetMoviesAverageRating()
        {
            var ratingSumm = 0.0;
            foreach (var watchedMovie in _watchedMovies)
            {
                ratingSumm += watchedMovie.Rating;
            }
            return ratingSumm/_watchedMovies.Count;
        }

        public double GetMoviesAverageRating(string specificGenre)
        {
            var ratingSumm = 0.0;
            var specificGenreMoviesCount = 0;
            foreach (var watchedMovie in _watchedMovies)
            {
                if (watchedMovie.Movie.Genre == specificGenre)
                {
                    ratingSumm += watchedMovie.Rating;
                    specificGenreMoviesCount++;
                }
            }
            return ratingSumm/specificGenreMoviesCount;
        }

        public void AddWatchedMovie(WatchedMovie watchedMovie)
        {
            _watchedMovies.Add(watchedMovie);
        }

        private List<WatchedMovie> _watchedMovies;
    }
}