using MinimalApi_Demo.Models;

namespace MinimalApi_Demo.Services
{
    public interface IUserService
    {
        public User Get(UserLogin login);
    }
}
