namespace MovieAdviser
{
    public interface IUserProfileRepository
    {
        IUserProfile[] GetAllUserProfiles();

        IUserProfile GetUserProfile(int userId);

        void SaveUserProfile(IUserProfile userProfile);
    }
}