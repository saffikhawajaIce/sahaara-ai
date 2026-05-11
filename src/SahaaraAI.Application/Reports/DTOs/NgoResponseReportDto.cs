namespace SahaaraAI.Application.Reports.DTOs;

public class NgoResponseReportDto
{
    public string NgoName { get; set; } = string.Empty;
    public int TotalResponses { get; set; }
    public int AcceptedCount { get; set; }
    public int RejectedCount { get; set; }
    public int PendingCount { get; set; }
}
