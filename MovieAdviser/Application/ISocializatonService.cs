namespace MovieAdviser
{
    public interface ISocializatonService
    {
        IUserProfile[] GetProfilesWithSameMovies(int userId);
    }
}