namespace SahaaraAI.Application.Dashboard.DTOs;

public class CaseWorkerDashboardDto
{
    public Guid UserId { get; set; }
    public List<DashboardMetricDto> Metrics { get; set; } = [];
    public List<RecentActivityDto> RecentActivities { get; set; } = [];
}
