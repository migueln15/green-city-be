﻿using green_city_be.DOMAIN.Core.DTO;
using green_city_be.DOMAIN.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace green_city_be.DOMAIN.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJWTService _jwtService;

        public UserService(IUserRepository userRepository, IJWTService jwtService)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
        }

        public async Task<UserResponseAuthDTO> SignIn(string email, string pwd)
        {
            var user = await _userRepository.SignIn(email, pwd);
            if (user == null) return null;

            var token = _jwtService.GenerateJWToken(user);

            var userResponseAuth = new UserResponseAuthDTO()
            {
                Id = user.Id,
                FullName = user.FullName,
                Email = email,
                Type = user.Type,
                Token = token
            };
            return userResponseAuth;
        }
    }
}