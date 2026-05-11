using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Cases.Services;

public interface ICaseStatusService
{
    public Task TransitionStatusAsync(Guid caseId, CaseStatus newStatus, string? reason);
    public bool CanTransition(CaseStatus currentStatus, CaseStatus newStatus);
}
