using green_city_be.DOMAIN.Core.Entities;
using green_city_be.DOMAIN.Core.Settings;

namespace green_city_be.DOMAIN.Core.Interfaces
{
    public interface IJWTService
    {
        JWTSettings _settings { get; }

        string GenerateJWToken(User user);
    }
}