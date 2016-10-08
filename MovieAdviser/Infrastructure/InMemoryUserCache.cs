using System.Collections.Generic;

namespace MovieAdviser
{
    public class InMemoryUserCache : IUserCache
    {
        public IUserProfile TryGetUser(int userId)
        {
            IUserProfile userProfile = null;
            _userCache.TryGetValue(userId, out userProfile);
            return userProfile;
        }

        public void SaveUser(IUserProfile userProfile)
        {
            if (userProfile == null)
            {
                return;
            }

            _userCache.Add(userProfile.Id, userProfile);
        }

        private Dictionary<int, IUserProfile> _userCache = new Dictionary<int, IUserProfile>();
    }
}