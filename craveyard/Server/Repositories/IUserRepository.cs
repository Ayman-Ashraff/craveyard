namespace craveyard.Server.Repositories
{
    public interface IUserRepository
    {
        int RegisterUser(User user); // Synchronous version, returns int directly
        User LoginUser(string username, string password); // Synchronous version, returns User directly
    }
}
