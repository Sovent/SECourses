namespace MovieAdviser
{
    public interface IRegistrationService
    {
        int RegisterUser(string email, string firstname, string lastname);
    }
}