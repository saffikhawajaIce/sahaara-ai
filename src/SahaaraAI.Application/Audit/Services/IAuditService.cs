using SahaaraAI.Application.Audit.DTOs;
using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Audit.Services;

public interface IAuditService
{
    Task RecordAsync(AuditActionType action, string entityName, Guid? entityId, string description);
    Task<IEnumerable<AuditEntryDto>> SearchAuditEntriesAsync(AuditSearchRequestDTO request);
}
