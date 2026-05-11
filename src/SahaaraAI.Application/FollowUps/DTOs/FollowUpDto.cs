using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.FollowUps.DTOs;

public class FollowUpDto
{
    public Guid Id { get; set; }
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public Guid? OutreachMessageId { get; set; }
    public FollowUpStatus Status { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? CompletedAt { get; set; }
    public string? Notes { get; set; }
    public string? GeneratedMessage { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
