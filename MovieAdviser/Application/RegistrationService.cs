namespace MovieAdviser
{
    public class RegistrationService : IRegistrationService
    {
        public RegistrationService(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public int RegisterUser(string email, string firstname, string lastname)
        {
            var newUserId = GetNewUserId();
            var newUserProfile = new UserProfile(newUserId, email, firstname, lastname, new WatchedMovie[0]);
            _userProfileRepository.SaveUserProfile(newUserProfile);
            return newUserId;
        }

        private int GetNewUserId()
        {
            var userProfiles = _userProfileRepository.GetAllUserProfiles();
            var maxUserId = 1;
            foreach (var userProfile in userProfiles)
            {
                if (userProfile.Id > maxUserId)
                {
                    maxUserId = userProfile.Id;
                }
            }

            return maxUserId + 1;
        }

        private readonly IUserProfileRepository _userProfileRepository;
    }
}