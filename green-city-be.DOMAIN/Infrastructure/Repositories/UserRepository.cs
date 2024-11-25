using green_city_be.DOMAIN.Core.Entities;
using green_city_be.DOMAIN.Core.Interfaces;
using green_city_be.DOMAIN.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace green_city_be.DOMAIN.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly GreenCityDbContext _dbContext;

        public UserRepository(GreenCityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> SignUp(User user)
        {
            await _dbContext.User.AddAsync(user);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<User> SignIn(string email, string pwd)
        {
            return await _dbContext
                .User
                .Where(x => x.Email == email && x.Password == pwd)
                .FirstOrDefaultAsync();
        }
    }
}
