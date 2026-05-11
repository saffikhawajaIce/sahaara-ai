namespace SahaaraAI.Application.Dashboard.DTOs;

public class DashboardMetricDto
{
    public string Label { get; set; } = string.Empty;
    public string? Value { get; set; }
    public string? Trend { get; set; }
}
