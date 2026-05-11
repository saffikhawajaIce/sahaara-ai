using SahaaraAI.Application.Audit.DTOs;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Application.Common.Interfaces.Persistence;

public interface IAuditRepository
{
    Task AddAsync(AuditEntry entry);
    Task<IEnumerable<AuditEntry>> SearchAsync(AuditSearchRequestDTO request);
}
