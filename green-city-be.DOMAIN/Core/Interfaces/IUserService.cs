﻿using green_city_be.DOMAIN.Core.DTO;

namespace green_city_be.DOMAIN.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserResponseAuthDTO> SignIn(string email, string pwd);
    }
}