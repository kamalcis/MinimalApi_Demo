using MinimalApi_Demo.Models;
using MinimalApi_Demo.Repositories;

namespace MinimalApi_Demo.Services
{
    public class UserService : IUserService
    {
        public User Get(UserLogin login)
        {
            User user = UserRepository.Users.Where(u => u.UserName.Equals(login.UserName, StringComparison.OrdinalIgnoreCase)
                        && u.Password.Equals(login.Password)).FirstOrDefault<User>();
            return user;
        }
    }
}
