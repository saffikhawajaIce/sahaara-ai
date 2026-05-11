using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Application.Common.Interfaces.Persistence;

public interface IOutreachRepository
{
    Task AddAsync(OutreachMessage message);
    Task<OutreachMessage?> GetByIdAsync(Guid id);
    Task<IEnumerable<OutreachMessage>> GetForCaseAsync(Guid caseId);
    void Update(OutreachMessage message);
}
