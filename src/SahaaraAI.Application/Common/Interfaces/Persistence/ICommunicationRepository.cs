using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Application.Common.Interfaces.Persistence;

public interface ICommunicationRepository
{
    Task AddAsync(CommunicationLog log);
    Task<IEnumerable<CommunicationLog>> GetTimelineForCaseAsync(Guid caseId);
    void Update(CommunicationLog log);
}
