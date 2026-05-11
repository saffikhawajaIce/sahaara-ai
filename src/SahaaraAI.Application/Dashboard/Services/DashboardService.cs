using SahaaraAI.Application.Dashboard.DTOs;

namespace SahaaraAI.Application.Dashboard.Services;

public class DashboardService : IDashboardService
{
    public Task<CaseWorkerDashboardDto> GetCaseWorkerDashboardAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<AdminDashboardDto> GetAdminDashboardAsync()
    {
        throw new NotImplementedException();
    }
}
