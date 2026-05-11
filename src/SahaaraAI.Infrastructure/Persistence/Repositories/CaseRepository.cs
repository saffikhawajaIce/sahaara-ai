using Microsoft.EntityFrameworkCore;
using SahaaraAI.Application.Common.Interfaces.Persistence;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Repositories;

public class CaseRepository : ICaseRepository
{
    private readonly SahaaraDbContext _dbContext;

    public CaseRepository(SahaaraDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task AddAsync(AssistanceCase assistanceCase) => _dbContext.AssistanceCases.AddAsync(assistanceCase).AsTask();

    public Task<AssistanceCase?> GetByIdAsync(Guid id) => _dbContext.AssistanceCases.FirstOrDefaultAsync(x => x.Id == id);

    public Task<AssistanceCase?> GetDetailedByIdAsync(Guid id) =>
        _dbContext.AssistanceCases
            .Include(x => x.Notes)
            .Include(x => x.NgoMatches)
            .Include(x => x.OutreachMessages)
            .FirstOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<AssistanceCase>> SearchAsync() => await _dbContext.AssistanceCases.ToListAsync();

    public void Update(AssistanceCase assistanceCase) => _dbContext.AssistanceCases.Update(assistanceCase);

    public async Task<IEnumerable<AssistanceCase>> GetCasesForApplicantAsync(Guid applicantId) =>
        await _dbContext.AssistanceCases.Where(x => x.ApplicantId == applicantId).ToListAsync();
}
