using MovieAdviser.Domain;
using System;

namespace MovieAdviser.Application
{
    public class MovieInformationService : IMovieInformationService
    {
        public MovieInformationService(
            IRepository<IUserProfile> userRepository, 
            IRepository<Movie> movieRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public double GetAverageMoviesRating(int userId)
        {
            var user = _userProfileRepository.GetUserProfile(userId);
            return user.GetMoviesAverageRating();
        }

        public double GetAverageMoviesRating(int userId, string specificGenre)
        {
            var user = _userProfileRepository.GetUserProfile(userId);
            return user.GetMoviesAverageRating(specificGenre);
        }

        public WatchedMovie[] GetWatchedMoviesByPeriod(int userId, DateTime @from, DateTime to)
        {
            var user = _userProfileRepository.GetUserProfile(userId);
            return user.GetWatchedMoviesByPeriod(@from, to);
        }

        private readonly IUserProfileRepository _userProfileRepository;
    }
}