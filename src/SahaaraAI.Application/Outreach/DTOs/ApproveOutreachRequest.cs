namespace SahaaraAI.Application.Outreach.DTOs;

public class ApproveOutreachRequestDTO
{
    public Guid ApprovedByUserId { get; set; }
    public string? Notes { get; set; }
}
