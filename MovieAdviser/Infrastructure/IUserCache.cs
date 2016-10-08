namespace MovieAdviser
{
    public interface IUserCache
    {
        IUserProfile TryGetUser(int userId);

        void SaveUser(IUserProfile userProfile);
    }
}