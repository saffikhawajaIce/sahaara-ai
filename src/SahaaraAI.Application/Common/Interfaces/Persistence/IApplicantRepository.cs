using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Application.Common.Interfaces.Persistence;

public interface IApplicantRepository
{
    Task AddAsync(Applicant applicant);
    Task<Applicant?> GetByIdAsync(Guid id);
    Task<IEnumerable<Applicant>> SearchAsync();
    void Update(Applicant applicant);
    Task<bool> ExistsByPhoneAsync(string phoneNumber);
}
