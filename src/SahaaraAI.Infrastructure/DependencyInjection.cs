using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SahaaraAI.Application.Common.Interfaces.AI;
using SahaaraAI.Application.Common.Interfaces.Email;
using SahaaraAI.Application.Common.Interfaces.Persistence;
using SahaaraAI.Application.Common.Interfaces.Security;
using SahaaraAI.Application.Common.Interfaces.Time;
using SahaaraAI.Infrastructure.AI;
using SahaaraAI.Infrastructure.Email;
using SahaaraAI.Infrastructure.Identity;
using SahaaraAI.Infrastructure.Persistence;
using SahaaraAI.Infrastructure.Persistence.Repositories;
using SahaaraAI.Infrastructure.Time;

namespace SahaaraAI.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string? connectionString = null)
    {
        services.AddDbContext<SahaaraDbContext>(options =>
        {
            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                options.UseNpgsql(connectionString);
            }
        });

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IApplicantRepository, ApplicantRepository>();
        services.AddScoped<ICaseRepository, CaseRepository>();
        services.AddScoped<INgoRepository, NgoRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IOutreachRepository, OutreachRepository>();
        services.AddScoped<ICommunicationRepository, CommunicationRepository>();
        services.AddScoped<IAuditRepository, AuditRepository>();

        services.AddScoped<IAiCaseAnalysisProvider, FakeAiProvider>();
        services.AddScoped<IAiOutreachProvider, FakeAiProvider>();
        services.AddScoped<IAiFollowUpProvider, FakeAiProvider>();

        services.AddScoped<IEmailSender, FakeEmailSender>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<IPasswordService, IdentityService>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        return services;
    }
}
