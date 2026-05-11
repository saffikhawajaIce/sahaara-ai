namespace SahaaraAI.Application.Dashboard.DTOs;

public class AdminDashboardDto
{
    public List<DashboardMetricDto> Metrics { get; set; } = [];
    public List<RecentActivityDto> RecentActivities { get; set; } = [];
}
