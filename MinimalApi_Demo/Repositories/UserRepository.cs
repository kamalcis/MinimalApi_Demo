using MinimalApi_Demo.Models;

namespace MinimalApi_Demo.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new List<User>
        {
            new User{Id=1,UserName="kamal_admin", Password="1234", EmailAddress="kamal.admin@gmail.com", 
                GivenName="Abu", Surname="Kamal"},
            new User{Id=2,UserName="zaman_standard", Password="5678", EmailAddress="zaman.standard@gmail.com", 
                GivenName="Noruzzaman", Surname="Khan"}

        };


    }
}
