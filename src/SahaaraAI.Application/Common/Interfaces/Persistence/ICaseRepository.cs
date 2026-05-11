using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Application.Common.Interfaces.Persistence;

public interface ICaseRepository
{
    Task AddAsync(AssistanceCase assistanceCase);
    Task<AssistanceCase?> GetByIdAsync(Guid id);
    Task<AssistanceCase?> GetDetailedByIdAsync(Guid id);
    Task<IEnumerable<AssistanceCase>> SearchAsync();
    void Update(AssistanceCase assistanceCase);
    Task<IEnumerable<AssistanceCase>> GetCasesForApplicantAsync(Guid applicantId);
}
