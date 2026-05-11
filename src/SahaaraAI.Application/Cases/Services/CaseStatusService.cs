using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Cases.Services;

public class CaseStatusService : ICaseStatusService
{
    public Task TransitionStatusAsync(Guid caseId, CaseStatus newStatus, string? reason)
    {
        throw new NotImplementedException();
    }

    public bool CanTransition(CaseStatus currentStatus, CaseStatus newStatus)
    {
        throw new NotImplementedException();
    }
}
