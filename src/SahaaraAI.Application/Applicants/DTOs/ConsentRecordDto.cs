using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Applicants.DTOs;

public class ConsentRecordDto
{
    public Guid Id { get; set; }
    public ConsentStatus Status { get; set; }
    public string ConsentText { get; set; } = string.Empty;
    public string? Notes { get; set; }
    public DateTime RecordedAt { get; set; }
    public Guid RecordedByUserId { get; set; }
}
