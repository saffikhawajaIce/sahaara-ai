using Microsoft.EntityFrameworkCore;
using SahaaraAI.Application.Audit.DTOs;
using SahaaraAI.Application.Common.Interfaces.Persistence;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Repositories;

public class AuditRepository : IAuditRepository
{
    private readonly SahaaraDbContext _dbContext;

    public AuditRepository(SahaaraDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task AddAsync(AuditEntry entry) => _dbContext.AuditEntries.AddAsync(entry).AsTask();

    public async Task<IEnumerable<AuditEntry>> SearchAsync(AuditSearchRequestDTO request)
    {
        var query = _dbContext.AuditEntries.AsQueryable();

        if (request.UserId.HasValue)
        {
            query = query.Where(x => x.UserId == request.UserId);
        }

        if (!string.IsNullOrWhiteSpace(request.EntityName))
        {
            query = query.Where(x => x.EntityName == request.EntityName);
        }

        return await query.OrderByDescending(x => x.CreatedAt).ToListAsync();
    }
}
