using Microsoft.EntityFrameworkCore;
using SahaaraAI.Application.Common.Interfaces.Persistence;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Repositories;

public class CommunicationRepository : ICommunicationRepository
{
    private readonly SahaaraDbContext _dbContext;

    public CommunicationRepository(SahaaraDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task AddAsync(CommunicationLog log) => _dbContext.CommunicationLogs.AddAsync(log).AsTask();

    public async Task<IEnumerable<CommunicationLog>> GetTimelineForCaseAsync(Guid caseId) =>
        await _dbContext.CommunicationLogs.Where(x => x.CaseId == caseId).OrderByDescending(x => x.OccurredAt).ToListAsync();

    public void Update(CommunicationLog log) => _dbContext.CommunicationLogs.Update(log);
}
