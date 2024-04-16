namespace Hospital_api.Helper
{
    public interface IBearerAuthentication
    {
        Task<string> AuthenticateAsync(string username, string password);
    }
}
