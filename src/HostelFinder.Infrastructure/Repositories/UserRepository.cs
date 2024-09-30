﻿using HostelFinder.Application.Interfaces.IRepositories;
using HostelFinder.Domain.Entities;
using HostelFinder.Infrastructure.Common;
using HostelFinder.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace HostelFinder.Infrastructure.Repositories
{
    public class UserRepository : BaseGenericRepository<User>, IUserRepository
    {
        public UserRepository(HostelFinderDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> CheckEmailExistAsync(string email)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Email == email);
            if(user == null)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> CheckPhoneNumberAsync(string phoneNumber)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Phone == phoneNumber);
            if (user == null)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> CheckUserNameExistAsync(string userName)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Username == userName);
            if (user == null)
            {
                return false;
            }
            return true;
        }

        public async Task<User?> FindByEmailAsync(string email)
        {
            var user = await _dbContext.Users.Where(x => x.Email.ToLower().Equals(email.ToLower()) && !x.IsDeleted).FirstOrDefaultAsync();

            if(user == null)
            {
                return null;
            }
            return user;
        }

        public async Task<User?> FindByUserNameAsync(string userName)
        {
            var user = await _dbContext.Users.Where(x => x.Username.ToLower().Equals(userName.ToLower()) && !x.IsDeleted).FirstOrDefaultAsync();
            if (user == null) 
            {
                return null;
            }
            return user;
        }
    }
}
