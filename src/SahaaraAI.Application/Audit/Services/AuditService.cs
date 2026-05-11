using SahaaraAI.Application.Audit.DTOs;
using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Audit.Services;

public class AuditService : IAuditService
{
    public Task RecordAsync(AuditActionType action, string entityName, Guid? entityId, string description)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AuditEntryDto>> SearchAuditEntriesAsync(AuditSearchRequestDTO request)
    {
        throw new NotImplementedException();
    }
}
