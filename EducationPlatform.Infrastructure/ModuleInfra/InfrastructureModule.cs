using EducationPlatform.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Infrastructure.ModuleInfra;
public static class InfrastructureModule
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddContext();

        return services;
    }

    private static IServiceCollection AddContext(this IServiceCollection services)
    {
        services.AddDbContext<EducationPlatformDbContext>(op => op.UseInMemoryDatabase("EducationPlatformDb"));

        return services;
    }
}
