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
public class subscriptionPlansRepository : IRepositoryBase<SubscriptionPlan>
{
    private readonly EducationPlatformDbContext _dbContext;

    public subscriptionPlansRepository(EducationPlatformDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<SubscriptionPlan> AddAsync(SubscriptionPlan entity)
    {
        var subPlan = await _dbContext.SubscriptionPlans.SingleOrDefaultAsync(sp => sp.Id == entity.Id);

        if (subPlan is not null)
        {
            await _dbContext.SubscriptionPlans.AddAsync(subPlan);
            await _dbContext.SaveChangesAsync();
        }   

        return entity;
    }

    public async Task<IEnumerable<SubscriptionPlan>> GetAllAsync()
    {
        return await _dbContext
            .SubscriptionPlans
            .OrderBy(sp => sp.Id)
            .ToListAsync();
    }

    public async Task<SubscriptionPlan?> GetByIdAsync(Guid id)
    {
        return await _dbContext.SubscriptionPlans.SingleOrDefaultAsync(sp => sp.Id == id);
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
