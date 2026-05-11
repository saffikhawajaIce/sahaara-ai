using Microsoft.EntityFrameworkCore;
using SahaaraAI.Application.Common.Interfaces.Persistence;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Repositories;

public class ApplicantRepository : IApplicantRepository
{
    private readonly SahaaraDbContext _dbContext;

    public ApplicantRepository(SahaaraDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task AddAsync(Applicant applicant) => _dbContext.Applicants.AddAsync(applicant).AsTask();

    public Task<Applicant?> GetByIdAsync(Guid id) => _dbContext.Applicants.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<Applicant>> SearchAsync() => await _dbContext.Applicants.ToListAsync();

    public void Update(Applicant applicant) => _dbContext.Applicants.Update(applicant);

    public Task<bool> ExistsByPhoneAsync(string phoneNumber) => _dbContext.Applicants.AnyAsync(x => x.PhoneNumber == phoneNumber);
}
