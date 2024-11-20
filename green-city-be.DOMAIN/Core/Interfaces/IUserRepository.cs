using green_city_be.DOMAIN.Core.Entities;

namespace green_city_be.DOMAIN.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> SignIn(string email, string pwd);
    }
}