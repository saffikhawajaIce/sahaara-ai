using Microsoft.EntityFrameworkCore;
using SahaaraAI.Application.Common.Interfaces.Persistence;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Repositories;

public class OutreachRepository : IOutreachRepository
{
    private readonly SahaaraDbContext _dbContext;

    public OutreachRepository(SahaaraDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task AddAsync(OutreachMessage message) => _dbContext.OutreachMessages.AddAsync(message).AsTask();

    public Task<OutreachMessage?> GetByIdAsync(Guid id) => _dbContext.OutreachMessages.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<OutreachMessage>> GetForCaseAsync(Guid caseId) =>
        await _dbContext.OutreachMessages.Where(x => x.CaseId == caseId).ToListAsync();

    public void Update(OutreachMessage message) => _dbContext.OutreachMessages.Update(message);
}
