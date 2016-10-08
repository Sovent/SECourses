using System.Collections.Generic;

namespace MovieAdviser
{
    public class SocializationService : ISocializatonService
    {
        public SocializationService(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public IUserProfile[] GetProfilesWithSameMovies(int userId)
        {
            var userProfiles = _userProfileRepository.GetAllUserProfiles();
            var userWatchedMovies = GetUserWatchedMovies(userProfiles, userId);
            var userWatchedMoviesNames = GetWatchedMoviesNames(userWatchedMovies);
            var profilesWithSameMovies = new List<IUserProfile>();
            foreach (var userProfile in userProfiles)
            {
                if (userProfile.Id == userId)
                {
                    continue;
                }

                foreach (var watchedMovie in userProfile.WatchedMovies)
                {
                    if (userWatchedMoviesNames.Contains(watchedMovie.Movie.Name))
                    {
                        profilesWithSameMovies.Add(userProfile);
                    }
                }
            }
            return profilesWithSameMovies.ToArray();
        }

        private WatchedMovie[] GetUserWatchedMovies(IUserProfile[] userProfiles, int userId)
        {
            foreach (var userProfile in userProfiles)
            {
                if (userProfile.Id == userId)
                {
                    return userProfile.WatchedMovies;
                }
            }

            return new WatchedMovie[0];
        }

        private List<string> GetWatchedMoviesNames(WatchedMovie[] watchedMovies)
        {
            var watchedMoviesNames = new List<string>();
            foreach (var watchedMovie in watchedMovies)
            {
                watchedMoviesNames.Add(watchedMovie.Movie.Name);
            }
            return watchedMoviesNames;
        }

        private readonly IUserProfileRepository _userProfileRepository;
    }
}