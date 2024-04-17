using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Repositories;
using EducationPlatform.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Infrastructure.Persistence.Repositories;
public class UsersRepository : IRepositoryBase<User>
{
    private readonly EducationPlatformDbContext _dbContext;

    public UsersRepository(EducationPlatformDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<User> AddAsync(User entity)
    {
        var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == entity.Id);

        if (user is not null)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }

        return entity;
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _dbContext.Users
            .OrderBy(u => u.Id)
            .ToListAsync();
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
