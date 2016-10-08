using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieAdviser;
namespace Lesson3
{
    [TestClass]
    public class InMemoryUserCacheTest
    {
        [TestMethod]
        public void SaveNotNullUserAndGetIt_ItIsReturned()
        {
            var userProfile = new UserProfile(1, "", "", "", null);
            var cache = new InMemoryUserCache();

            cache.SaveUser(userProfile);
            var retrievedUser = cache.TryGetUser(1);

            Assert.IsNotNull(retrievedUser);
        }
    }
}
