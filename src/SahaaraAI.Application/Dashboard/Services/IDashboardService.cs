using SahaaraAI.Application.Dashboard.DTOs;

namespace SahaaraAI.Application.Dashboard.Services;

public interface IDashboardService
{
    Task<CaseWorkerDashboardDto> GetCaseWorkerDashboardAsync(Guid userId);
    Task<AdminDashboardDto> GetAdminDashboardAsync();
}
